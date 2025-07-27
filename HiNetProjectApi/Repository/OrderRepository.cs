using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookEcommerceDbContext db;

        public OrderRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<Order> CreateAsync(Order order)
        {
            await db.Orders.AddAsync(order);
            await db.SaveChangesAsync();
            return order;

        }

        public async Task<Order?> DeleteAsync(Guid id)
        {
            var order = await GetByIdAsync(id);
            if (order != null)
            {
                db.Orders.Remove(order);
                await db.SaveChangesAsync();
            }
            return order;
        }

        public IQueryable<Order> GetAllAsync()
        {
            //Sau chuyển vào service
            //if (userId != Guid.Empty)
            //{
            //    orders = orders.Where(o => o.Id == userId);
            //}

            //if (status != null)
            //{
            //    orders = orders.Where(o => o.Status == status);
            //}

            //if (timeCreated != null)
            //{
            //    orders = orders.Where(o => o.CreateAt == timeCreated);
            //}
            return db.Orders.AsNoTracking().AsQueryable();
        }

        public async Task<Order?> GetByIdAsync(Guid id)
        {
            var order = await db.Orders.FindAsync(id);
            return order;
        }

        public async Task<Order?> UpdateAsync(Guid id, Order order)
        {
            var orderUpdate = await GetByIdAsync(id);
            if (orderUpdate != null)
            {
                orderUpdate.Status = order.Status;
                db.SaveChanges();
            }
            return orderUpdate;
        }
    }
}
