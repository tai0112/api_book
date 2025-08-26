using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepositoriy
{
    public interface INotificationRepository
    {
        IQueryable<Notification> GetAllAsync();
        Task<Notification?> GetByIdAsync(Guid id);
        Task<Notification> CreateAsync(Notification notification);
        Task<Notification?> UpdateAsync(Guid id, Notification notification);
        Task<Notification?> RemoveAsync(Guid id);
        Task MarkAsReadAsync(Guid notificationId);
    }
}
