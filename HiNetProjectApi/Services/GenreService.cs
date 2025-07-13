using AutoMapper;
using FluentValidation;
using HiNetProjectApi.Helpers;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;
using HiNetProjectApi.Repository.IRepository;
using HiNetProjectApi.Services.IServices;

namespace HiNetProjectApi.Services
{
    public class GenreService : IGenreService
    {
        private readonly IMapper mapper;
        private readonly IGenreRepository genreRepository;
        private readonly IValidator<AddRequestGenreDTO> addGenreValidator;
        private readonly IValidator<UpdateRequestGenreDTO> updateGenreValidator;

        public GenreService(IMapper mapper, IGenreRepository genreRepository, IValidator<AddRequestGenreDTO> addGenreValidator, IValidator<UpdateRequestGenreDTO> updateGenreValidator)
        {
            this.mapper = mapper;
            this.genreRepository = genreRepository;
            this.addGenreValidator = addGenreValidator;
            this.updateGenreValidator = updateGenreValidator;
        }
        public async Task<GenreDTO> CreateAsync(AddRequestGenreDTO genreDTO)
        {
            var validate = addGenreValidator.Validate(genreDTO);
            if (!validate.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validate.Errors));
            }
            var genre = mapper.Map<Genre>(genreDTO);
            await genreRepository.CreateAsync(genre);
            return mapper.Map<GenreDTO>(genre);
        }

        public async Task<GenreDTO> DeleteAsync(Guid id)
        {
            var genre = await genreRepository.RemoveAsync(id);
            var genreDTO = mapper.Map<GenreDTO>(genre);
            return genreDTO;
        }

        public async Task<IEnumerable<GenreDTO>> GetAllAsync(string? name = "", DateTime? timeCreated = null, DateTime? timeUpdated = null)
        {
            var genres = await genreRepository.GetAllAsync(name, timeCreated, timeUpdated);
            return mapper.Map<List<GenreDTO>>(genres);
        }

        public async Task<GenreDTO> GetByIdAsync(Guid id)
        {
            var genre = await genreRepository.GetByIdAsync(id);
            return mapper.Map<GenreDTO>(genre);
        }

        public async Task<GenreDTO> UpdateAsync(Guid id, UpdateRequestGenreDTO genreDTO)
        {
            var validate = updateGenreValidator.Validate(genreDTO);
            if (!validate.IsValid)
            {
                throw new ArgumentException(ValidationHelper.FormatErrors(validate.Errors));
            }
            var genreDomain = mapper.Map<Genre>(genreDTO);
            var genreUpdate = await genreRepository.UpdateAsync(id, genreDomain);
            return mapper.Map<GenreDTO>(genreUpdate);
        }
    }
}
