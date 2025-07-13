using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class GenreValidator : AbstractValidator<GenreDTO>
    {
        public GenreValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
