using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IPublisherService
    {
        Task<IEnumerable<PublisherDTO>> GetAllAsync(string? name = "");
        Task<PublisherDTO?> GetByIdAsync(Guid id);
        Task<PublisherDTO> CreateAsync(AddPublisherRequestDTO addPublisherRequestDTO);
        Task<PublisherDTO?> UpdateAsync(Guid id, UpdatePublisherRequestDTO updatePublisherRequestDTO);
        Task<PublisherDTO?> RemoveAsync(Guid id);
    }
}
