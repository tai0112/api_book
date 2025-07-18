using HiNetProjectApi.Data;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserRepository(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<ApplicationUser> CreateAsync(ApplicationUser user, string password)
        {
            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "user");
                return user;
            }

            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        public IQueryable<ApplicationUser> GetAllAsync()
        {
            return userManager.Users.Include(o => o.Cart).AsQueryable();
        }

        // Lấy user theo Id
        public async Task<ApplicationUser?> GetByIdAsync(Guid id)
        {
            return await userManager.Users.Include(o => o.Cart).FirstOrDefaultAsync(u => u.Id == id.ToString());
        }

        // Cập nhật user
        public async Task<ApplicationUser> UpdateAsync(Guid id, ApplicationUser updatedUser)
        {
            var user = await userManager.Users.FirstOrDefaultAsync(u => u.Id == id.ToString());

            if (user == null)
            {
                throw new Exception("User không tồn tại.");
            }

            user.FullName = updatedUser.FullName;
            user.Address = updatedUser.Address;
            user.Email = updatedUser.Email;
            user.PhoneNumber = updatedUser.PhoneNumber;
            user.UserName = updatedUser.UserName;

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return user;
            }

            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        // Xóa user theo Id
        public async Task<ApplicationUser> RemoveAsync(Guid id)
        {
            var user = await userManager.Users.FirstOrDefaultAsync(u => u.Id == id.ToString());

            if (user == null)
            {
                throw new Exception("User không tồn tại.");
            }

            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return user;
            }

            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
        }
    }
}
