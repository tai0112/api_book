using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IStockQuantityRepository
    {
        Task<IEnumerable<StockQuantity?>> GetAllAsync(Guid? bookId);
        Task<StockQuantity?> GetQuantity(Guid bookId);
        Task<StockQuantity?> GetByIdAsync(Guid id);
        Task<StockQuantity> CreateAsync(StockQuantity stockQuantity);
        Task<StockQuantity?> UpdateAsync(Guid id, StockQuantity stockQuantity);
        Task<StockQuantity?> UpdateQuantity(Guid id, int quantity);
        Task<StockQuantity?> RemoveAsync(Guid id);
    }
}
