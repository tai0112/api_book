using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface ICoverTypeRepository
    {
        Task<IEnumerable<CoverType>> GetAllAsync(string? name = "");
        Task<CoverType?> GetByIdAsync(Guid id);
        Task<CoverType> CreateAsync(CoverType coverType);
        Task<CoverType?> UpdateAsync(Guid id, CoverType coverType);
        Task<CoverType?> RemoveAsync(Guid id);
    }
}
