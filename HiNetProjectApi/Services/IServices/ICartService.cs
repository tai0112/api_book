using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface ICartService
    {
        Task<IEnumerable<CartDTO?>> GetAllAsync(string userId);
        Task<CartDTO?> GetByIdAsync(Guid id);
        Task<CartDTO> CreateAsync(AddCartRequestDTO addCartRequestDTO);
        Task<CartDTO?> UpdateAsync(Guid id, UpdateCartRequestDTO updateCartRequestDTO);
        Task<CartDTO?> RemoveAsync(Guid id);
    }
}
