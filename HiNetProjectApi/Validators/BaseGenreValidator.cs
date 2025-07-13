using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseGenreValidator<T> : AbstractValidator<T> where T : BaseGenreDTO
    {
        public BaseGenreValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
