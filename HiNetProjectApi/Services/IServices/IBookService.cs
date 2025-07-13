using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> GetAllAsync(Guid? ageRating = null, Guid? coverType = null, string? name = "", string? code = "", string? note = "", string? author = "", string? description = "", string? language = "", float price = 0, int pageTotal = 0, string publisher = "", string? subGenre = "");
        Task<BookDTO?> GetByIdAsync(Guid id);
        Task<BookDTO> CreateAsync(AddBookRequestDTO addBookRequestDTO);
        Task<BookDTO?> UpdateAsync(Guid id, UpdateBookRequestDTO updateBookRequestDTO);
        Task<BookDTO?> RemoveAsync(Guid id);
    }
}
