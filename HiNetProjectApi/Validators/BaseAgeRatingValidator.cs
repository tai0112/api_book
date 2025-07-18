using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseAgeRatingValidator<T> : AbstractValidator<T> where T : BaseAgeRatingDTO
    {
        public BaseAgeRatingValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
