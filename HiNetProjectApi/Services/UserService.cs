using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepositoriy;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.AspNetCore.Identity;

namespace HiNetProjectApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IValidator<RegisterUserRequestDTO> addValidator;
        private readonly IMapper mapper;
        private readonly ICartService cartService;
        private readonly IValidator<LoginUserRequestDTO> loginValidator;
        private readonly ITokenRepository tokenRepository;

        public UserService(IUserRepository userRepository, UserManager<ApplicationUser> userManager, IValidator<RegisterUserRequestDTO> addValidator, IMapper mapper, ICartService cartService, IValidator<LoginUserRequestDTO> loginValidator, ITokenRepository tokenRepository)
        {
            this.userRepository = userRepository;
            this.userManager = userManager;
            this.addValidator = addValidator;
            this.mapper = mapper;
            this.cartService = cartService;
            this.loginValidator = loginValidator;
            this.tokenRepository = tokenRepository;
        }
        public async Task<UserDTO> CreateAsync(RegisterUserRequestDTO registerUserRequestDTO, string password)
        {
            var validation = addValidator.Validate(registerUserRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var userDomain = mapper.Map<ApplicationUser>(registerUserRequestDTO);
            var user = await userRepository.CreateAsync(userDomain, password);

            var userId = user.Id;
            var cartDTO = new AddCartRequestDTO()
            {
                UserId = userId,
                TotalPrice = 0
            };

            var cart = await cartService.CreateAsync(cartDTO);
            return mapper.Map<UserDTO>(user);
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync(string address = "", string email = "", string phone = "", string username = "")
        {
            var users = await userRepository.GetAllAsync(address, email, phone, username);
            return mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO?> GetByIdAsync(Guid id)
        {
            var user = await userRepository.GetByIdAsync(id);
            return mapper.Map<UserDTO>(user);
        }

        public async Task<LoginResponseDTO> Login(LoginUserRequestDTO loginRequestDTO)
        {
            var validation = loginValidator.Validate(loginRequestDTO);
            var user = await userManager.FindByNameAsync(loginRequestDTO.UserName);
            if (user != null)
            {
                if (await userManager.CheckPasswordAsync(user, loginRequestDTO.Password))
                {
                    var roles = await userManager.GetRolesAsync(user);
                    var jwt = tokenRepository.CreateJWTToken(user, roles.ToList());
                    return new LoginResponseDTO
                    {
                        JWT = jwt,
                    };
                }
            }
            throw new Exception("Login fail");
        }

        public async Task<UserDTO> RemoveAsync(Guid id)
        {
            var user = await userRepository.RemoveAsync(id);
            return mapper.Map<UserDTO>(user);
        }

        public Task<UserDTO> UpdateAsync(Guid id, UpdateUserRequestDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
