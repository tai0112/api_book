using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Services.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync(string? address = "", string? email = "", string? phone = "", string? username = "");
        Task<UserDTO?> GetByIdAsync(Guid id);
        Task<UserDTO> CreateAsync(RegisterUserRequestDTO user, string password);
        Task<UserDTO> UpdateAsync(Guid id, UpdateUserRequestDTO user);
        Task<UserDTO> RemoveAsync(Guid id);
        Task<LoginResponseDTO> Login(LoginUserRequestDTO login);
    }
}
