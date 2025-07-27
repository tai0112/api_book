using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface ISubGenreService
    {
        Task<IEnumerable<SubGenreDTO>> GetAllAsync(SearchSubGenreDTO serch);
        Task<SubGenreDTO?> GetByIdAsync(Guid id);
        Task<SubGenreDTO> CreateAsync(AddSubGenreRequestDTO addSubGenreRequestDTO);
        Task<SubGenreDTO?> UpdateAsync(Guid id, UpdateSubGenreRequestDTO updateSubGenreRequestDTO);
        Task<SubGenreDTO?> RemoveAsync(Guid id);
    }
}
