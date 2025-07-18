using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IPublisherRepository
    {
        IQueryable<Publisher> GetAllAsync();
        Task<Publisher?> GetByIdAsync(Guid id);
        Task<Publisher> CreateAsync(Publisher publisher);
        Task<Publisher?> UpdateAsync(Guid id, Publisher publisher);
        Task<Publisher?> RemoveAsync(Guid id);
    }
}
