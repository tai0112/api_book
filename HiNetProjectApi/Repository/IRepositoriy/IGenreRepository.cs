using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllAsync(string? name = "", DateTime? timeCreated = null, DateTime? timeUpdated = null);
        Task<Genre?> GetByIdAsync(Guid id);
        Task<Genre> CreateAsync(Genre genre);
        Task<Genre?> UpdateAsync(Guid id, Genre genre);
        Task<Genre?> RemoveAsync(Guid id);
    }
}
