using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class SubGenreRepository : ISubGenreRepository
    {
        private readonly BookEcommerceDbContext db;

        public SubGenreRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<SubGenre> CreateAsync(SubGenre subGenre)
        {
            await db.SubGenres.AddAsync(subGenre);
            await db.SaveChangesAsync();
            return subGenre;
        }

        public IQueryable<SubGenre> GetAllAsync()
        {
            return db.SubGenres.AsQueryable();
        }
        public async Task<SubGenre?> GetByIdAsync(Guid id)
        {
            var subGenre = await db.SubGenres.FirstOrDefaultAsync(o => o.Id == id);
            return subGenre;
        }

        public async Task<SubGenre?> RemoveAsync(Guid id)
        {
            var subGenre = await GetByIdAsync(id);
            if (subGenre != null)
            {
                db.SubGenres.Remove(subGenre);
                await db.SaveChangesAsync();
            }
            return subGenre;
        }

        public async Task<SubGenre?> UpdateAsync(Guid id, SubGenre subGenre)
        {
            var subGenreUpdate = await GetByIdAsync(id);
            if (subGenreUpdate != null)
            {
                subGenreUpdate.UpdateAt = DateTime.UtcNow;
                subGenreUpdate.GenreId = subGenre.GenreId;
                subGenreUpdate.Name = subGenre.Name;
                await db.SaveChangesAsync();
            }
            return subGenre;
        }
    }
}
