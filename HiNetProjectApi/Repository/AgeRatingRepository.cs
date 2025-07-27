using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class AgeRatingRepository : IAgeRatingRepository
    {
        private readonly BookEcommerceDbContext db;

        public AgeRatingRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<AgeRating> CreateAsync(AgeRating ageRating)
        {
            await db.AgeRatings.AddAsync(ageRating);
            await db.SaveChangesAsync();
            return ageRating;
        }

        public async Task<AgeRating?> DeleteAsync(Guid id)
        {
            var ageRating = await GetByIdAsync(id);
            if (ageRating != null)
            {
                db.AgeRatings.Remove(ageRating);
                await db.SaveChangesAsync();
            }
            return ageRating;
        }

        public IQueryable<AgeRating> GetAllAsync()
        {
            return db.AgeRatings.AsNoTracking().AsQueryable();
        }

        public async Task<AgeRating?> GetByIdAsync(Guid id)
        {
            var ageRating = await db.AgeRatings.FindAsync(id);
            return ageRating;
        }

        public async Task<AgeRating> UpdateAsync(Guid id, AgeRating ageRating)
        {
            var updateRating = await GetByIdAsync(id);
            if (updateRating != null)
            {
                updateRating.Name = ageRating.Name;
                await db.SaveChangesAsync();
            }
            return ageRating;
        }
    }
}
