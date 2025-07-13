using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllAsync(Guid userId, string? status, DateTime? timeCreated);
        Task<Order?> GetByIdAsync(Guid id);
        Task<Order> CreateAsync(Order order);
        Task<Order?> UpdateAsync(Guid id, Order order);
        Task<Order?> DeleteAsync(Guid id);
    }
}
