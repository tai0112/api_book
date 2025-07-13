using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IStockQuantityService
    {
        Task<IEnumerable<StockQuantityDTO?>> GetAllAsync(Guid? bookId = null);
        Task<StockQuantityDTO?> GetByIdAsync(Guid id);
        Task<StockQuantityDTO> CreateAsync(AddStockQuantityDTO stockQuantity);
        Task<StockQuantityDTO?> UpdateAsync(Guid id, UpdateStockQuantityRequestDTO stockQuantity);
        Task<StockQuantityDTO?> RemoveAsync(Guid id);
        Task<StockQuantityDTO?> UpdateQuantity(Guid bookId, int quantity);
        Task<bool> IsStockQuantityAvailable(Guid bookId, int quantity);
    }
}
