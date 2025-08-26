using AutoMapper;
using HiNetProjectApi.Hubs;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepositoriy;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace HiNetProjectApi.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository notificationRepository;
        private readonly ILogger logger;
        private readonly IMapper mapper;
        private readonly IHubContext<NotificationHub> hubContext;

        public NotificationService(INotificationRepository notificationRepository, ILogger logger, IMapper mapper, IHubContext<NotificationHub> hubContext)
        {
            this.notificationRepository = notificationRepository;
            this.logger = logger;
            this.mapper = mapper;
            this.hubContext = hubContext;
        }
        public async Task<NotificationDTO> CreateNotificationAsync(AddRequestNotificationDTO addRequestNotificationDTO)
        {
            try
            {
                var notificationDomain = mapper.Map<Notification>(addRequestNotificationDTO);
                var notification = await notificationRepository.CreateAsync(notificationDomain);
                return mapper.Map<NotificationDTO>(notification);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "Error creating notification");
                throw;
            }
        }

        public async Task DeleteNotificationAsync(Guid notificationId)
        {
            try
            {
                var notification = await notificationRepository.GetByIdAsync(notificationId);
                if (notification == null)
                {
                    logger.LogWarning("Notification with ID {NotificationId} not found", notificationId);
                    return;
                }
                await notificationRepository.RemoveAsync(notificationId);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "Error deleting notification");
                throw;
            }
        }

        public async Task<NotificationDTO> GetNotificationByIdAsync(Guid notificationId)
        {
            try
            {
                var notification = await notificationRepository.GetByIdAsync(notificationId);
                return mapper.Map<NotificationDTO>(notification);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "Error retrieving notification by ID");
                throw;
            }
        }

        public async Task<IEnumerable<NotificationDTO?>> GetNotificationsAsync(string userId)
        {
            try
            {
                var notifications = notificationRepository.GetAllAsync();
                if (!string.IsNullOrEmpty(userId))
                {
                    notifications = notifications.Where(x => x.UserId.Equals(userId));
                }
                notifications = notifications.OrderByDescending(x => x.CreatedAt);
                var result = await notifications.ToListAsync();
                return mapper.Map<IEnumerable<NotificationDTO>>(result);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "Error retrieving notifications for user ID {UserId}", userId);
                throw;
            }
        }

        public async Task<int> GetUnreadNotificationCountAsync(string userId)
        {
            try
            {
                var notifications = await GetNotificationsAsync(userId);
                if (notifications == null)
                {
                    return 0;
                }
                var unreadCount = notifications.Count(n => n != null && !n.IsRead);
                return unreadCount;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error counting unread notifications for user ID {UserId}", userId);
                throw;
            }
        }

        public Task LogNotificationAsync(string type, string recipient, string content)
        {
            throw new NotImplementedException();
        }

        public async Task MarkNotificationAsReadAsync(Guid notificationId)
        {
            try
            {
                await notificationRepository.MarkAsReadAsync(notificationId);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "Error marking notification as read with ID {NotificationId}", notificationId);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error marking notification as read with ID {NotificationId}", notificationId);
                throw;
            }
        }

        public Task SendEmailAsync(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }

        public async Task SendNotification(string userId, string message)
        {
            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    var notification = new Notification
                    {
                        Message = message,
                        IsRead = false,
                        CreatedAt = DateTime.UtcNow
                    };
                    if (!string.IsNullOrEmpty(userId))
                    {
                        notification.UserId = userId;
                        await notificationRepository.CreateAsync(notification);
                        await hubContext.Clients.User(userId).SendAsync("ReceiveMessage", message);
                    }else
                    {
                        await notificationRepository.CreateAsync(notification);
                        await hubContext.Clients.All.SendAsync("ReceiveMessage", message);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error sending notification to user ID {UserId}", userId);
                throw;
            }
        }

        public Task SendPushNotificationAsync(string deviceToken, string title, string message)
        {
            throw new NotImplementedException();
        }

        public Task SendSmsAsync(string to, string message)
        {
            throw new NotImplementedException();
        }

        public async Task<NotificationDTO?> UpdateNotificationAsync(Guid id, UpdateRequestNotificationDTO updateRequestNotificationDTO)
        {
            try
            {
                var notifcationDomain = mapper.Map<Notification>(updateRequestNotificationDTO);
                var notification = await notificationRepository.UpdateAsync(id, notifcationDomain);
                if (notification == null)
                {
                    logger.LogWarning("Notification with ID {Id} not found", id);
                    return null;
                }
                return mapper.Map<NotificationDTO>(notification);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "Error updating notification with ID {Id}", id);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error updating notification with ID {Id}", id);
                throw;
            }
        }
    }
}
