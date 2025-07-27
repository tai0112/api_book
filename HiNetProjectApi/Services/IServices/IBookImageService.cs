using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IBookImageService
    {
        Task<IEnumerable<BookImageDTO>> GetImagesAsync(SearchBookImageDTO search);
        Task<BookImageDTO> GetImageAsync(Guid id);
        Task<BookImageDTO> DeleteAsync(Guid id);
        Task<BookImageDTO> CreateAsync(AddBookImageRequestDTO image);
        Task<BookImageDTO> UpdateAsync(Guid id, UpdateBookImageRequestDTO image);
        Task RemoveRange(SearchBookImageDTO search);
    }
}
