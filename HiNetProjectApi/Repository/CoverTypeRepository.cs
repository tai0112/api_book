using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class CoverTypeRepository : ICoverTypeRepository
    {
        private readonly BookEcommerceDbContext db;

        public CoverTypeRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<CoverType> CreateAsync(CoverType coverType)
        {
            await db.CoverTypes.AddAsync(coverType);
            await db.SaveChangesAsync();
            return coverType;
        }

        public async Task<IEnumerable<CoverType>> GetAllAsync(string? name = "")
        {
            var coverTypes = db.CoverTypes.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                coverTypes = coverTypes.Where(o => o.Name.Equals(name));
            }
            return await coverTypes.ToListAsync();
        }

        public async Task<CoverType?> GetByIdAsync(Guid id)
        {
            var coverType = await db.CoverTypes.FindAsync(id);
            return coverType;
        }

        public async Task<CoverType?> RemoveAsync(Guid id)
        {
            var coverType = await GetByIdAsync(id);
            if (coverType != null)
            {
                db.CoverTypes.Remove(coverType);
                await db.SaveChangesAsync();
            }
            return coverType;
        }

        public async Task<CoverType?> UpdateAsync(Guid id, CoverType coverType)
        {
            var coverTypeUpdate = await GetByIdAsync(id);
            if (coverTypeUpdate != null)
            {
                coverTypeUpdate.Name = coverType.Name;
                await db.SaveChangesAsync();
            }
            return coverType;
        }
    }
}
