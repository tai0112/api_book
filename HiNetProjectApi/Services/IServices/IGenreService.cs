using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IGenreService
    {
        Task<GenreDTO> CreateAsync(AddRequestGenreDTO genreDTO);
        Task<GenreDTO> DeleteAsync(Guid id);
        Task<GenreDTO> UpdateAsync(Guid id, UpdateRequestGenreDTO genreDTO);
        Task<GenreDTO> GetByIdAsync(Guid id);
        Task<IEnumerable<GenreDTO>> GetAllAsync(string? name = "", DateTime? timeCreated = null, DateTime? timeUpdated = null);

    }
}
