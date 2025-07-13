using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;

namespace HiNetProjectApi.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IMapper mapper;
        private readonly IPublisherRepository publisherRepository;
        private readonly IValidator<AddPublisherRequestDTO> addValidator;
        private readonly IValidator<UpdatePublisherRequestDTO> updateValidator;

        public PublisherService(IMapper mapper, IPublisherRepository publisherRepository, IValidator<AddPublisherRequestDTO> addValidator, IValidator<UpdatePublisherRequestDTO> updateValidator)
        {
            this.mapper = mapper;
            this.publisherRepository = publisherRepository;
            this.addValidator = addValidator;
            this.updateValidator = updateValidator;
        }
        public async Task<PublisherDTO> CreateAsync(AddPublisherRequestDTO addPublisherRequestDTO)
        {
            var validation = addValidator.Validate(addPublisherRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }

            var publisherDomain = mapper.Map<Publisher>(addPublisherRequestDTO);
            var publisher = await publisherRepository.CreateAsync(publisherDomain);
            return mapper.Map<PublisherDTO>(publisher);
        }

        public async Task<IEnumerable<PublisherDTO>> GetAllAsync(string? name = "")
        {
            var publishers = await publisherRepository.GetAllAsync(name);
            return mapper.Map<IEnumerable<PublisherDTO>>(publishers);
        }

        public async Task<PublisherDTO?> GetByIdAsync(Guid id)
        {
            var publisher = await publisherRepository.GetByIdAsync(id);
            return mapper.Map<PublisherDTO>(publisher);
        }

        public async Task<PublisherDTO?> RemoveAsync(Guid id)
        {
            var publisher = await publisherRepository.RemoveAsync(id);
            return mapper.Map<PublisherDTO>(publisher);
        }

        public async Task<PublisherDTO?> UpdateAsync(Guid id, UpdatePublisherRequestDTO updatePublisherRequestDTO)
        {
            var validation = updateValidator.Validate(updatePublisherRequestDTO);
            if (!validation.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validation.Errors));
            }
            var publisherDomain = mapper.Map<Publisher>(updatePublisherRequestDTO);
            var publisher = await publisherRepository.UpdateAsync(id, publisherDomain);
            return mapper.Map<PublisherDTO>(publisher);
        }
    }
}
