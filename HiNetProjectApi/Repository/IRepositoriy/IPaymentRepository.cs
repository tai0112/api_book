using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetAllAsync(string? userId, Guid? orderId, DateTime? timeCreated, DateTime? timeUpdated, float? price, string? note = "");
        Task<Payment?> GetByIdAsync(Guid id);
        Task<Payment> CreateAsync(Payment payment);
        Task<Payment?> UpdateAsync(Guid id, Payment payment);
        Task<Payment?> RemoveAsync(Guid id);
    }
}
