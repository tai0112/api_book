using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class StockQuantityRepository : IStockQuantityRepository
    {
        private readonly BookEcommerceDbContext db;

        public StockQuantityRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<StockQuantity> CreateAsync(StockQuantity stockQuantity)
        {
            await db.StockQuantities.AddAsync(stockQuantity);
            await db.SaveChangesAsync();
            return stockQuantity;
        }

        public IQueryable<StockQuantity> GetAllAsync()
        {
            return db.StockQuantities.AsNoTracking().AsQueryable();
        }

        public async Task<StockQuantity?> GetByIdAsync(Guid id)
        {
            var stockQuantity = await db.StockQuantities.FindAsync(id);
            return stockQuantity;
        }

        public async Task<StockQuantity?> GetQuantity(Guid bookId)
        {
            var stockQuantity = await db.StockQuantities.Where(o => o.BookId ==  bookId).FirstOrDefaultAsync();
            return stockQuantity;
        }

        public async Task<StockQuantity?> RemoveAsync(Guid id)
        {
            var stockQuantity = await GetByIdAsync(id);
            if (stockQuantity != null)
            {
                db.StockQuantities.Remove(stockQuantity);
                await db.SaveChangesAsync();
            }
            return stockQuantity;
        }

        public async Task<StockQuantity?> UpdateAsync(Guid id, StockQuantity stockQuantity)
        {
            var stockQuantityUpdate = await GetByIdAsync(id);
            if (stockQuantityUpdate != null)
            {
                stockQuantityUpdate.Quantities = stockQuantity.Quantities;
                await db.SaveChangesAsync();
            }
            return stockQuantity;
        }

        public async Task<StockQuantity?> UpdateQuantity(Guid id, int quantity)
        {
            var stockQuantity = await db.StockQuantities.FirstOrDefaultAsync(o => o.BookId == id);
            if (stockQuantity != null)
            {
                stockQuantity.Quantities += quantity;
                await db.SaveChangesAsync();
            }
            return stockQuantity;

        }
    }
}
