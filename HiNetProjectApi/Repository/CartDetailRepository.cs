using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class CartDetailRepository : ICartDetailRepository
    {
        private readonly BookEcommerceDbContext db;

        public CartDetailRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<CartDetail> CreateAsync(CartDetail cartDetail)
        {
            await db.CartDetails.AddAsync(cartDetail);
            await db.SaveChangesAsync();
            return cartDetail;
        }

        public async Task<IEnumerable<CartDetail?>> GetAllAsync(Guid cartId)
        {
            var cartDetails = db.CartDetails.AsQueryable();
            if (cartId != Guid.Empty)
            {   
                cartDetails = cartDetails.Where(o => o.Id == cartId);
            }

            return await cartDetails.ToListAsync();
        }

        public async Task<CartDetail?> GetByIdAsync(Guid id)
        {
            var cartDetail = await db.CartDetails.FindAsync(id);
            return cartDetail;
        }

        public async Task<CartDetail?> GetCartDetailByCartIdAndBookId(Guid cartId, Guid bookId)
        {
            var cartDetail = await db.CartDetails.Where(o => o.CartId == cartId && o.BookId == bookId).FirstOrDefaultAsync();
            return cartDetail;
        }


        public async Task<CartDetail?> RemoveAsync(Guid id)
        {
            var cartDetail = await GetByIdAsync(id);
            if (cartDetail != null)
            {
                db.CartDetails.Remove(cartDetail);
                await db.SaveChangesAsync();
            }
            return cartDetail;
        }

        public async Task<CartDetail?> UpdateAsync(Guid id, CartDetail cart)
        {
            var cartDetailUpdate = await GetByIdAsync(id);
            if (cartDetailUpdate != null)
            {
                
                cartDetailUpdate.PriceInit = cart.PriceInit;
                cartDetailUpdate.Quantity = cart.Quantity;
                cart.PriceTotal = cart.PriceInit * cart.Quantity;
                await db.SaveChangesAsync();
            }
            return cart;
        }

        public async Task<CartDetail?> UpdateAsync(Guid id, Guid bookId, int quantity)
        {
            var cartDetail = await GetCartDetailByCartIdAndBookId(id, bookId);
            if (cartDetail != null)
            {
                cartDetail.Quantity += quantity;
                cartDetail.PriceTotal += cartDetail.PriceInit * cartDetail.Quantity;
                await db.SaveChangesAsync();
            }
            return cartDetail;
        }
    }
}
