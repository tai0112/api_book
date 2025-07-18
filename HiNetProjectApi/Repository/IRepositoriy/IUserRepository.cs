using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IUserRepository
    {
        IQueryable<ApplicationUser> GetAllAsync();
        Task<ApplicationUser?> GetByIdAsync(Guid id);
        Task<ApplicationUser> CreateAsync(ApplicationUser user, string password);
        Task<ApplicationUser> UpdateAsync(Guid id, ApplicationUser user);
        Task<ApplicationUser> RemoveAsync(Guid id);
    }
}
