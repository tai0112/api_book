using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface ICoverTypeService
    {
        Task<IEnumerable<CoverTypeDTO>> GetAllAsync(string? name = "");
        Task<CoverTypeDTO?> GetByIdAsync(Guid id);
        Task<CoverTypeDTO> CreateAsync(AddCoverTypeRequestDTO coverTypeDTO);
        Task<CoverTypeDTO?> UpdateAsync(Guid id, UpdateCoverTypeRequestDTO coverType);
        Task<CoverTypeDTO?> RemoveAsync(Guid id);
    }
}
