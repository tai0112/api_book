using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using HiNetProjectApi.Validators;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace HiNetProjectApi.Services
{
    public class AgeRatingService : IAgeRatingService
    {
        private readonly IAgeRatingRepository ageRatingRepository;
        private readonly IMapper mapper;
        private readonly IValidator<AddAgeRatingRequestDTO> addValidator;
        private readonly IValidator<UpdateRequestAgeRatingDTO> updateValidator;

        public AgeRatingService(IAgeRatingRepository ageRatingRepository, IMapper mapper, IValidator<AddAgeRatingRequestDTO> addValidator, IValidator<UpdateRequestAgeRatingDTO> updateValidator)
        {
            this.ageRatingRepository = ageRatingRepository;
            this.mapper = mapper;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
        }
        public async Task<AgeRatingDTO> CreateAsync(AddAgeRatingRequestDTO addAgeRatingRequestDTO)
        {
            var validation = addValidator.Validate(addAgeRatingRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }
            var ageRatingDomain = mapper.Map<AgeRating>(addAgeRatingRequestDTO);
            await ageRatingRepository.CreateAsync(ageRatingDomain);
            return mapper.Map<AgeRatingDTO>(ageRatingDomain);
        }

        public async Task<IEnumerable<AgeRatingDTO?>> GetAgeRatingsAsync(string name, string description)
        {
            var ageRating = ageRatingRepository.GetAllAsync();
            if (!string.IsNullOrEmpty(name))
            {
                ageRating = ageRating.Where(x => x.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(description))
            {
                ageRating = ageRating.Where(x =>x.Description.Contains(description));
            }

            var result = await ageRating.ToListAsync();

            return mapper.Map<List<AgeRatingDTO>>(result);
        }

        public async Task<AgeRatingDTO?> GetAgeRatingAsync(Guid id)
        {
            var ageRating = await ageRatingRepository.GetByIdAsync(id);
            return mapper.Map<AgeRatingDTO>(ageRating);
        }

        public async Task<AgeRatingDTO> RemoveAsync(Guid id)
        {
            var ageRating = await ageRatingRepository.DeleteAsync(id);
            return mapper.Map<AgeRatingDTO>(ageRating);

        }

        public async Task<AgeRatingDTO> UpdateAsync(Guid id, UpdateRequestAgeRatingDTO updateAgeRatingRequestDTO)
        {
            var validation = updateValidator.Validate(updateAgeRatingRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var ageRatingDomain = mapper.Map<AgeRating>(updateAgeRatingRequestDTO);
            var ageRatingUpdate = await ageRatingRepository.UpdateAsync(id, ageRatingDomain);
            return mapper.Map<AgeRatingDTO>(ageRatingUpdate);
        }
    }
}
