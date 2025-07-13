using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.Identity.Client;

namespace HiNetProjectApi.Services
{
    public class CoverTypeService : ICoverTypeService
    {
        private readonly ICoverTypeRepository coverTypeRepository;
        private readonly IValidator<AddCoverTypeRequestDTO> addValidator;
        private readonly IValidator<UpdateCoverTypeRequestDTO> updateValidator;
        private readonly IMapper mapper;

        public CoverTypeService(ICoverTypeRepository coverTypeRepository, IValidator<AddCoverTypeRequestDTO> addValidator, IValidator<UpdateCoverTypeRequestDTO> updateValidator, IMapper mapper)
        {
            this.coverTypeRepository = coverTypeRepository;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
            this.mapper = mapper;
        }
        public async Task<CoverTypeDTO> CreateAsync(AddCoverTypeRequestDTO coverTypeDTO)
        {
            var validate = addValidator.Validate(coverTypeDTO);
            if (!validate.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validate.Errors));
            }

            var coverTypeDomain = mapper.Map<CoverType>(coverTypeDTO);
            var coverType = await coverTypeRepository.CreateAsync(coverTypeDomain);
            return mapper.Map<CoverTypeDTO>(coverType);
        }

        public async Task<IEnumerable<CoverTypeDTO>> GetAllAsync(string? name = null)
        {
            var coverTypes = await coverTypeRepository.GetAllAsync(name);
            return mapper.Map<IEnumerable<CoverTypeDTO>>(coverTypes);
        }

        public async Task<CoverTypeDTO?> GetByIdAsync(Guid id)
        {
            var coverType = await coverTypeRepository.GetByIdAsync(id);
            return mapper.Map<CoverTypeDTO>(coverType);
        }

        public async Task<CoverTypeDTO?> RemoveAsync(Guid id)
        {
            var coverType = await coverTypeRepository.RemoveAsync(id);
            return mapper.Map<CoverTypeDTO>(coverType);
        }

        public async Task<CoverTypeDTO?> UpdateAsync(Guid id, UpdateCoverTypeRequestDTO updateCoverTypeRequestDTO)
        {
            var validation = updateValidator.Validate(updateCoverTypeRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }
            var coverTypeDomain = mapper.Map<CoverType>(updateCoverTypeRequestDTO);
            var coverType = await coverTypeRepository.UpdateAsync(id, coverTypeDomain);
            return mapper.Map<CoverTypeDTO>(coverType);
        }
    }
}
