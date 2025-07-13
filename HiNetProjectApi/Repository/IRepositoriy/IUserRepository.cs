using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllAsync(string? address = "", string? email = "", string? phone = "", string? username = "");
        Task<ApplicationUser?> GetByIdAsync(Guid id);
        Task<ApplicationUser> CreateAsync(ApplicationUser user, string password);
        Task<ApplicationUser> UpdateAsync(Guid id, ApplicationUser user);
        Task<ApplicationUser> RemoveAsync(Guid id);
    }
}
