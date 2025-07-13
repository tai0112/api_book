using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly BookEcommerceDbContext db;

        public GenreRepository(BookEcommerceDbContext db)
        {
            this.db = db;
        }
        public async Task<Genre> CreateAsync(Genre genre)
        {
            await db.Genres.AddAsync(genre);
            await db.SaveChangesAsync();
            return genre;
        }

        public async Task<IEnumerable<Genre>> GetAllAsync(string? name = "", DateTime? timeCreated = null, DateTime? timeUpdated = null)
        {
            var genres = db.Genres.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                genres = genres.Where(o => o.Name.Contains(name));
            }

            if (timeCreated != null)
            {
                genres = genres.Where(o => o.CreateAt.Equals(timeCreated));
            }

            if (timeUpdated != null)
            {
                genres = genres.Where(o => o.UpdateAt.Equals(timeUpdated));
            }

            var result = await genres.Include(o => o.SubGenres).ToListAsync();
           
            return await genres.Include(o => o.SubGenres).ToListAsync();
        }

        public async Task<Genre?> GetByIdAsync(Guid id)
        {
            var genre = await db.Genres.Where(o => o.Id == id).Include(o => o.SubGenres).FirstOrDefaultAsync();
            return genre;
        }

        public async Task<Genre?> RemoveAsync(Guid id)
        {
            var genre = await GetByIdAsync(id);
            if (genre != null)
            {
                db.Genres.Remove(genre);
                await db.SaveChangesAsync();
            }
            return genre;
        }

        public async Task<Genre?> UpdateAsync(Guid id, Genre genre)
        {
            var genreUpdate = await GetByIdAsync(id);
            if (genreUpdate != null)
            {
                genreUpdate.Name = genre.Name;
                genreUpdate.UpdateAt = DateTime.Now;
                await db.SaveChangesAsync();
            }
            return genre;
        }
    }
}
