using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface ICartDetailRepository
    {
        IQueryable<CartDetail?> GetAllAsync();
        Task<CartDetail?> GetCartDetailByCartIdAndBookId(Guid cartId, Guid bookId);
        Task<CartDetail?> GetByIdAsync(Guid id);
        Task<CartDetail> CreateAsync(CartDetail cartDetail);
        Task<CartDetail?> UpdateAsync(Guid id, Guid bookId, int quantity);
        Task<CartDetail?> RemoveAsync(Guid id);
        
    }
}
