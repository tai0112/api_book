using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IBookImageRepository
    {
        IQueryable<BookImage> GetAllAsync();
        Task<BookImage?> GetByIdAsync(Guid id);
        Task<BookImage> CreateAsync(BookImage bookImage);
        Task<BookImage?> UpdateAsync(Guid id, BookImage bookImage);
        Task<BookImage?> DeleteAsync(Guid id);
    }
}
