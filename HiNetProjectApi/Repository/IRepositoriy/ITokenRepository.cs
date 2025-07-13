using HiNetProjectApi.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace HiNetProjectApi.Repository.IRepositoriy
{
    public interface ITokenRepository
    {
        string CreateJWTToken(ApplicationUser user, List<string>roles);
    }

}
