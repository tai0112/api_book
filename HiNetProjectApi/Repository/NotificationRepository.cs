using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepositoriy;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly BookEcommerceDbContext db;

        public NotificationRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }

        public async Task<Notification> CreateAsync(Notification notification)
        {
            await db.Notifications.AddAsync(notification);
            await db.SaveChangesAsync();
            return notification;
        }

        public IQueryable<Notification> GetAllAsync()
        {
            var notifications = db.Notifications.AsNoTracking().AsQueryable();
            return notifications;
        }

        public async Task<Notification?> GetByIdAsync(Guid id)
        {
            var notification = await db.Notifications.FindAsync(id);
            return notification;
        }

        public async Task MarkAsReadAsync(Guid notificationId)
        {
            var notification = await GetByIdAsync(notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                await UpdateAsync(notificationId, notification);
                await db.SaveChangesAsync();
            }
        }

        public async Task<Notification?> RemoveAsync(Guid id)
        {
            var notification = await GetByIdAsync(id);
            if (notification != null)
            {
                db.Notifications.Remove(notification);
                await db.SaveChangesAsync();
                return notification;
            }
            return null;
        }

        public async Task<Notification?> UpdateAsync(Guid id, Notification notification)
        {
            var notificationUpdate = await GetByIdAsync(id);
            if (notificationUpdate != null)
            {
                notificationUpdate.Message = notification.Message;
                notificationUpdate.IsRead = notification.IsRead;
                db.SaveChanges();
                return notificationUpdate;
            }
            return null;
        }
    }
}
