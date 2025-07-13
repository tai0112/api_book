using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepositoriy
{
    public interface IOrderDetailRepository
    {
        Task<IEnumerable<OrderDetail>> GetAllAsync(Guid orderId, string? bookName);
        Task<OrderDetail?> GetByIdAsync(Guid id);
        Task<OrderDetail> CreateAsync(OrderDetail orderDetail);
        Task<OrderDetail?> UpdateAsync(Guid id, OrderDetail orderDetail);
        Task<OrderDetail?> DeleteAsync(Guid id);
    }
}
