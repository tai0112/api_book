using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepositoriy;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly BookEcommerceDbContext db;

        public OrderDetailRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<OrderDetail> CreateAsync(OrderDetail orderDetail)
        {
            await db.OrderDetails.AddAsync(orderDetail);
            await db.SaveChangesAsync();
            return orderDetail;
        }

        public async Task<OrderDetail?> DeleteAsync(Guid id)
        {
            var orderDetail = await GetByIdAsync(id);
            if (orderDetail != null)
            {
                db.OrderDetails.Remove(orderDetail);
                await db.SaveChangesAsync();
            }
            return orderDetail;
        }

        public Task<IEnumerable<OrderDetail>> GetAllAsync(Guid orderId, string? bookName)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDetail?> GetByIdAsync(Guid id)
        {
            var orderDetail = await db.OrderDetails.FindAsync(id);
            return orderDetail;
        }

        public async Task<OrderDetail?> UpdateAsync(Guid id, OrderDetail orderDetail)
        {
            var orderDetailUpdate = await GetByIdAsync(id);
            if (orderDetailUpdate != null )
            {
                orderDetailUpdate.PriceInit = orderDetail.PriceInit;
                orderDetailUpdate.Quantity = orderDetail.Quantity;
                orderDetailUpdate.PriceTotal = orderDetailUpdate.Quantity * orderDetailUpdate.PriceInit;
                await db.SaveChangesAsync();
            }
            return orderDetailUpdate;
        }
    }
}
