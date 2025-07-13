using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly BookEcommerceDbContext db;

        public PublisherRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<Publisher> CreateAsync(Publisher publisher)
        {
            await db.Publishers.AddAsync(publisher);
            await db.SaveChangesAsync();
            return publisher;
        }

        public async Task<IEnumerable<Publisher>> GetAllAsync(string? name = "")
        {
            var publisers = db.Publishers.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                publisers = publisers.Where(o => o.Name.Equals(name));
            }
            return await publisers.ToListAsync();
        }

        public async Task<Publisher?> GetByIdAsync(Guid id)
        {
            var publisher = await db.Publishers.FindAsync(id);
            return publisher;
        }

        public async Task<Publisher?> RemoveAsync(Guid id)
        {
            var publisher = await GetByIdAsync(id);
            if (publisher != null)
            {
                db.Publishers.Remove(publisher);
                await db.SaveChangesAsync();
            }
            return publisher;
        }

        public async Task<Publisher?> UpdateAsync(Guid id, Publisher publisher)
        {
            var publisherUpdate = await GetByIdAsync(id);
            if (publisherUpdate != null)
            {
                publisherUpdate.Name = publisher.Name;
                await db.SaveChangesAsync();
            }
            return publisherUpdate;
        }
    }
}
