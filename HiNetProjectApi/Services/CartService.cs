using System.ComponentModel.DataAnnotations;
using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens.Experimental;

namespace HiNetProjectApi.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;
        private readonly IMapper mapper;
        private readonly IValidator<AddCartRequestDTO> addValidator;
        private readonly IValidator<UpdateCartRequestDTO> updateValidator;

        public CartService(ICartRepository cartRepository, IMapper mapper, IValidator<AddCartRequestDTO> addValidator, IValidator<UpdateCartRequestDTO> updateValidator)
        {
            this.cartRepository = cartRepository;
            this.mapper = mapper;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
        }
        public async Task<CartDTO> CreateAsync(AddCartRequestDTO addCartRequestDTO)
        {
            var validation = addValidator.Validate(addCartRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var cartDomain = mapper.Map<Cart>(addCartRequestDTO);
            var cart = await cartRepository.CreateAsync(cartDomain);
            return mapper.Map<CartDTO>(cart);
        }

        public async Task<IEnumerable<CartDTO?>> GetAllAsync(string userId)
        {
            var carts = await cartRepository.GetAllAsync(userId);
            return mapper.Map<IEnumerable<CartDTO>>(carts);
        }

        public async Task<CartDTO?> GetByIdAsync(Guid id)
        {
            var cart = await cartRepository.GetByIdAsync(id);
            return mapper.Map<CartDTO>(cart);
        }

        public async Task<CartDTO?> RemoveAsync(Guid id)
        {
            var cart = await cartRepository.RemoveAsync(id);
            return mapper.Map<CartDTO>(cart);
        }

        public async Task<CartDTO?> UpdateAsync(Guid id, UpdateCartRequestDTO updateCartRequestDTO)
        {
            var validation = updateValidator.Validate(updateCartRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var cartDomain = mapper.Map<Cart>(updateCartRequestDTO);
            var cart = await cartRepository.UpdateAsync(id, cartDomain);
            return mapper.Map<CartDTO>(cart);
        }
    }
}
