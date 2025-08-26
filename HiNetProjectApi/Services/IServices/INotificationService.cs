using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface INotificationService
    {
        Task SendEmailAsync(string to, string subject, string body);
        Task SendSmsAsync(string to, string message);
        Task SendPushNotificationAsync(string deviceToken, string title, string message);
        Task SendNotification (string userId, string message);
        Task LogNotificationAsync(string type, string recipient, string content);
        Task<NotificationDTO> CreateNotificationAsync(AddRequestNotificationDTO addRequestNotificationDTO);
        Task<NotificationDTO?> UpdateNotificationAsync(Guid id, UpdateRequestNotificationDTO addRequestNotificationDTO);
        Task<IEnumerable<NotificationDTO?>> GetNotificationsAsync(string userId);
        Task<NotificationDTO> GetNotificationByIdAsync(Guid notificationId);
        Task MarkNotificationAsReadAsync(Guid notificationId);
        Task DeleteNotificationAsync(Guid notificationId);
        Task <int> GetUnreadNotificationCountAsync(string userId);
    }
}
