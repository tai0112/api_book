using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync(Guid? ageRating, Guid? coverType, string? name = "", string? code = "", string? note = "", string? author = "", string? description = "", string? language = "", float price = 0, int pageTotal = 0, string publisher = "", string? subGenre = "");
        Task<Book?> GetByIdAsync(Guid id);
        Task<Book> CreateAsync(Book book);
        Task<Book?> UpdateAsync(Guid id, Book book);
        Task<Book?> RemoveAsync(Guid id);
    }
}
