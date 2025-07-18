using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface ICoverTypeRepository
    {
        IQueryable<CoverType> GetAllAsync();
        Task<CoverType?> GetByIdAsync(Guid id);
        Task<CoverType> CreateAsync(CoverType coverType);
        Task<CoverType?> UpdateAsync(Guid id, CoverType coverType);
        Task<CoverType?> RemoveAsync(Guid id);
    }
}
