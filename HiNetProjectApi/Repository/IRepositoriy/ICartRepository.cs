using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface ICartRepository
    {
        IQueryable<Cart?> GetAllAsync();
        Task<Cart?> GetByIdAsync(Guid id);
        Task<Cart> CreateAsync(Cart cart);
        Task<Cart?> UpdateAsync(Guid id, Cart cart);
        Task<Cart?> RemoveAsync(Guid id);
    }
}
