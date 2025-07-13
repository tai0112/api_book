using System.Runtime.CompilerServices;
using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;

namespace HiNetProjectApi.Services
{
    public class StockQuantityService : IStockQuantityService
    {
        private readonly IStockQuantityRepository stockQuantityRepository;
        private readonly IValidator<UpdateStockQuantityRequestDTO> updateValidator;
        private readonly IValidator<AddStockQuantityDTO> addValidator;
        private readonly IMapper mapper;

        public StockQuantityService(IStockQuantityRepository stockQuantityRepository, IValidator<UpdateStockQuantityRequestDTO> updateValidator, IValidator<AddStockQuantityDTO> addValidator, IMapper mapper)
        {
            this.stockQuantityRepository = stockQuantityRepository;
            this.updateValidator = updateValidator;
            this.addValidator = addValidator;
            this.mapper = mapper;
        }

        public async Task<StockQuantityDTO> CreateAsync(AddStockQuantityDTO addStockQuantityDTO)
        {
            var validation = addValidator.Validate(addStockQuantityDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var stockQuantityDomain = mapper.Map<StockQuantity>(addStockQuantityDTO);
            var stockQuantity = await stockQuantityRepository.CreateAsync(stockQuantityDomain);
            return mapper.Map<StockQuantityDTO>(stockQuantity);

        }

        public async Task<IEnumerable<StockQuantityDTO?>> GetAllAsync(Guid? bookId)
        {
            var stockQuantities = await stockQuantityRepository.GetAllAsync(bookId);
            return mapper.Map<List<StockQuantityDTO?>>(stockQuantities);
        }

        public async Task<StockQuantityDTO?> GetByIdAsync(Guid id)
        {
            var stockQuantity = await stockQuantityRepository.GetByIdAsync(id);
            return mapper.Map<StockQuantityDTO>(stockQuantity);
        }

        public async Task<bool> IsStockQuantityAvailable(Guid bookId, int quantity)
        {
            var stockQuantity = await stockQuantityRepository.GetQuantity(bookId);
            if (stockQuantity != null)
            {
                if (stockQuantity.Quantities > quantity)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public async Task<StockQuantityDTO?> RemoveAsync(Guid id)
        {
            var stockQuantity = await stockQuantityRepository.RemoveAsync(id);
            return mapper.Map<StockQuantityDTO>(stockQuantity);
        }

        public async Task<StockQuantityDTO?> UpdateAsync(Guid id, UpdateStockQuantityRequestDTO updateStockQuantity)
        {
            var validation = updateValidator.Validate(updateStockQuantity);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var stockQuantityDomain = mapper.Map<StockQuantity>(updateStockQuantity);
            var stockQuantity = await stockQuantityRepository.UpdateAsync(id, stockQuantityDomain);
            return mapper.Map<StockQuantityDTO>(stockQuantity);
        }

        public async Task<StockQuantityDTO?> UpdateQuantity(Guid bookId, int quantity)
        {
            var stockQuantity = await stockQuantityRepository.UpdateQuantity(bookId, quantity);
            return mapper.Map<StockQuantityDTO>(stockQuantity);
        }
    }
}
