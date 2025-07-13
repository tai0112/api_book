using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly BookEcommerceDbContext db;

        public CartRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<Cart> CreateAsync(Cart cart)
        {
            await db.Carts.AddAsync(cart);
            await db.SaveChangesAsync();
            return cart;
        }

        public async Task<IEnumerable<Cart?>> GetAllAsync(string userId)
        {
            var carts = db.Carts.AsQueryable();
            if (!string.IsNullOrEmpty(userId))
            {
                carts = carts.Where(o => o.UserId == userId);
            }
            return await carts.Include(o => o.CartDetails).Include(o => o.User).ToListAsync();   
        }

        public async Task<Cart?> GetByIdAsync(Guid id)
        {
            var cart = await db.Carts.Include(o => o.CartDetails).FirstOrDefaultAsync(o => o.Id == id);
            return cart;
        }

        public async Task<Cart?> RemoveAsync(Guid id)
        {
            var cart = await GetByIdAsync(id);
            if (cart != null)
            {
                db.Carts.Remove(cart);
                await db.SaveChangesAsync();
            }
            return cart;
        }

        public async Task<Cart?> UpdateAsync(Guid id, Cart cart)
        {
            var cartUpdate = await GetByIdAsync(id);
            if (cartUpdate != null)
            {
                cartUpdate.TotalPrice = cart.CartDetails.Sum(o => o.PriceTotal);
                await db.SaveChangesAsync();
            }
            return cartUpdate;
        }
    }
}
