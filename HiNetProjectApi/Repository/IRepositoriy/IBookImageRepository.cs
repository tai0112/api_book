using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IBookImageRepository
    {
        Task<IEnumerable<BookImage>> GetAllAsync(Guid? bookId, bool? isMain, string? fileName = "");
        Task<BookImage?> GetByIdAsync(Guid id);
        Task<BookImage> CreateAsync(BookImage bookImage);
        Task<BookImage?> UpdateAsync(Guid id, BookImage bookImage);
        Task<BookImage?> DeleteAsync(Guid id);
    }
}
