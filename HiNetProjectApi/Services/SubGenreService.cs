using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace HiNetProjectApi.Services
{
    public class SubGenreService : ISubGenreService
    {
        private readonly ISubGenreRepository subGenreRepository;
        private readonly IMapper mapper;
        private readonly IValidator<AddSubGenreRequestDTO> addSubGenreValidator;
        private readonly IValidator<UpdateSubGenreRequestDTO> updateSubGenreValidator;

        public SubGenreService(ISubGenreRepository subGenreRepository, IMapper mapper, IValidator<AddSubGenreRequestDTO> addSubGenreValidator, IValidator<UpdateSubGenreRequestDTO> updateSubGenreValidator)
        {
            this.subGenreRepository = subGenreRepository;
            this.mapper = mapper;
            this.addSubGenreValidator = addSubGenreValidator;
            this.updateSubGenreValidator = updateSubGenreValidator;
        }
        public async Task<SubGenreDTO> CreateAsync(AddSubGenreRequestDTO addSubGenreRequestDTO)
        {
            var validate = addSubGenreValidator.Validate(addSubGenreRequestDTO);
            if (!validate.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validate.Errors));
            }
            var subGenreDomain = mapper.Map<SubGenre>(addSubGenreRequestDTO);
            var subGenre = await subGenreRepository.CreateAsync(subGenreDomain);
            return mapper.Map<SubGenreDTO>(subGenre);
        }

        public async Task<IEnumerable<SubGenreDTO>> GetAllAsync(SearchSubGenreDTO search)
        {
            var subGenres = subGenreRepository.GetAllAsync();
            if (!string.IsNullOrEmpty(search.Name))
            {
                subGenres = subGenres.Where(o => o.Name == search.Name);
            }

            if (search.GenreId != null)
            {
                subGenres = subGenres.Where(o => o.GenreId == search.GenreId);
            }

            var result = await subGenres.ToListAsync();

            return mapper.Map<List<SubGenreDTO>>(subGenres);
        }

        public async Task<SubGenreDTO?> GetByIdAsync(Guid id)
        {
            var subGenre = await subGenreRepository.GetByIdAsync(id);
            return mapper.Map<SubGenreDTO>(subGenre);
        }

        public async Task<SubGenreDTO?> RemoveAsync(Guid id)
        {
            var subGenre = await subGenreRepository.RemoveAsync(id);
            return mapper.Map<SubGenreDTO>(subGenre);
        }

        public async Task<SubGenreDTO?> UpdateAsync(Guid id, UpdateSubGenreRequestDTO updateSubGenreRequestDTO)
        {
            var validate = updateSubGenreValidator.Validate(updateSubGenreRequestDTO);
            if (!validate.IsValid)
            {
                throw new InvalidOperationException(ValidationHelper.FormatErrors(validate.Errors));
            }
            var subGenreDomain = mapper.Map<SubGenre>(updateSubGenreRequestDTO);
            var subGenre = await subGenreRepository.UpdateAsync(id, subGenreDomain);
            return mapper.Map<SubGenreDTO?>(subGenre);
        }
    }
}
