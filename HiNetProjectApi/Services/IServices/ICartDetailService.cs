using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface ICartDetailService
    {
        Task<IEnumerable<CartDetailDTO?>> GetAllAsync(Guid cartId);
        Task<CartDetailDTO?> GetByIdAsync(Guid id);
        Task<CartDetailDTO> CreateAsync(AddCartDetailRequestDTO cartDetail);
        Task<CartDetailDTO?> UpdateAsync(Guid id, Guid bookId, int quanity);
        Task<CartDetailDTO?> RemoveAsync(Guid id);
    }
}
