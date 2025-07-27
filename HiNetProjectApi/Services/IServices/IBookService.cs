using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> GetAllAsync(SearchBookDTO search);
        Task<BookDTO?> GetByIdAsync(Guid id);
        Task<BookDTO> CreateAsync(AddBookRequestDTO addBookRequestDTO);
        Task<BookDTO?> UpdateAsync(Guid id, UpdateBookRequestDTO updateBookRequestDTO);
        Task<BookDTO?> RemoveAsync(Guid id);
    }
}
