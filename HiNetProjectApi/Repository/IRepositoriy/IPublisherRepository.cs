using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IPublisherRepository
    {
        Task<IEnumerable<Publisher>> GetAllAsync(string? name = "");
        Task<Publisher?> GetByIdAsync(Guid id);
        Task<Publisher> CreateAsync(Publisher publisher);
        Task<Publisher?> UpdateAsync(Guid id, Publisher publisher);
        Task<Publisher?> RemoveAsync(Guid id);
    }
}
