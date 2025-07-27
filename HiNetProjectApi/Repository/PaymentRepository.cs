using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly BookEcommerceDbContext db;

        public PaymentRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<Payment> CreateAsync(Payment payment)
        {
            await db.Payments.AddAsync(payment);
            await db.SaveChangesAsync();
            return payment;
        }

        public async Task<IEnumerable<Payment>> GetAllAsync(string? userId, Guid? orderId, DateTime? timeCreated, DateTime? timeUpdated, float? price, string? note = "")
        {
            var payments = db.Payments.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(userId))
            {
                payments = payments.Where(o => o.UserId == userId);
            }

            if (orderId != Guid.Empty)
            {
                payments = payments.Where(o => o.Order.Id == orderId);
            }

            if (timeCreated != DateTime.MinValue)
            {
                payments = payments.Where(o => o.CreateAt == timeCreated);
            }

            if (!string.IsNullOrEmpty(note))
            {
                payments = payments.Where((o) => o.Note == note);
            }

            if (price != null)
            {
                payments = payments.Where(o => o.PriceTotal == price);
            }
            return await payments.ToListAsync();
        }

        public async Task<Payment?> GetByIdAsync(Guid id)
        {
            var payment = await db.Payments.FindAsync(id);
            return payment;
        }

        public async Task<Payment?> RemoveAsync(Guid id)
        {
            var payment = await GetByIdAsync(id);
            if (payment != null)
            {
                db.Payments.Remove(payment);
                await db.SaveChangesAsync();
            }
            return payment;
        }

        public async Task<Payment?> UpdateAsync(Guid id, Payment payment)
        {
            var paymentUpdate = await GetByIdAsync(id);
            if (paymentUpdate != null)
            {
                paymentUpdate.Note = payment.Note;
                paymentUpdate.PriceTotal = payment.PriceTotal;
                await db.SaveChangesAsync();
            }
            return paymentUpdate;
        }
    }
}
