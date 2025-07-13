using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class GenreCreateValidator : AbstractValidator<AddRequestGenreDTO>
    {
        public GenreCreateValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
