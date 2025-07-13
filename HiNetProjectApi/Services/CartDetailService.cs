using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;

namespace HiNetProjectApi.Services
{
    public class CartDetailService : ICartDetailService
    {
        private readonly ICartDetailRepository cartDetailRepository;
        private readonly IMapper mapper;
        private readonly IValidator<AddCartDetailRequestDTO> addValidator;
        private readonly IValidator<UpdateCartDetailRequestDTO> updateValidator;
        private readonly IStockQuantityService stockQuantityService;

        public CartDetailService(ICartDetailRepository cartDetailRepository, IMapper mapper, IValidator<AddCartDetailRequestDTO> addValidator, IValidator<UpdateCartDetailRequestDTO> updateValidator, IStockQuantityService stockQuantityService)
        {
            this.cartDetailRepository = cartDetailRepository;
            this.mapper = mapper;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
            this.stockQuantityService = stockQuantityService;
        }


        public async Task<CartDetailDTO> CreateAsync(AddCartDetailRequestDTO addCartDetailRequestDTO)
        {
            var validation = addValidator.Validate(addCartDetailRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            if (await stockQuantityService.IsStockQuantityAvailable(addCartDetailRequestDTO.BookId, addCartDetailRequestDTO.Quantity))
            {
                var existingCartDetail = await cartDetailRepository.GetCartDetailByCartIdAndBookId(addCartDetailRequestDTO.CartId, addCartDetailRequestDTO.BookId);
                if (existingCartDetail == null)
                {
                    var cartDetailDomain = mapper.Map<CartDetail>(addCartDetailRequestDTO);
                    var cartDetail = await cartDetailRepository.CreateAsync(cartDetailDomain);
                    return mapper.Map<CartDetailDTO>(cartDetail);
                }

                var updated = await cartDetailRepository.UpdateAsync(existingCartDetail.CartId, existingCartDetail.BookId, addCartDetailRequestDTO.Quantity);
                await stockQuantityService.UpdateQuantity(addCartDetailRequestDTO.BookId, -(addCartDetailRequestDTO.Quantity));
                return mapper.Map<CartDetailDTO>(updated);
            }
            throw new Exception("Not enough quantity");

        }

        public async Task<IEnumerable<CartDetailDTO?>> GetAllAsync(Guid cartId)
        {
            var cartDetails = await cartDetailRepository.GetAllAsync(cartId);
            return mapper.Map<IEnumerable<CartDetailDTO>>(cartDetails);
        }

        public async Task<CartDetailDTO?> GetByIdAsync(Guid id)
        {
            var cartDetail = await cartDetailRepository.GetByIdAsync(id);
            return mapper.Map<CartDetailDTO>(cartDetail);
        }

        public async Task<CartDetailDTO?> RemoveAsync(Guid id)
        {
            var cartDetail = await cartDetailRepository.RemoveAsync(id);
            return mapper.Map<CartDetailDTO>(cartDetail);
        }

        public async Task<CartDetailDTO?> UpdateAsync(Guid id, Guid bookId, int quanity)
        {
            var cartDetail = await cartDetailRepository.GetCartDetailByCartIdAndBookId(id, bookId);
            if (cartDetail != null)
            {
                if (await stockQuantityService.IsStockQuantityAvailable(bookId, quanity))
                {
                    await cartDetailRepository.UpdateAsync(cartDetail.Id, bookId, quanity);
                }
                return mapper.Map<CartDetailDTO>(cartDetail);
            }
            throw new Exception("Not enough quantity");
        }
    }
}
