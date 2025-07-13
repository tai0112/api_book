using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseSubGenreValidator<T> : AbstractValidator<T> where T : BaseSubGenreDTO
    {
        public BaseSubGenreValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
            RuleFor(o => o.GenreId).NotEmpty();
        }
    }
}
