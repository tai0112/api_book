using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseAgeRatingValidator<T> : AbstractValidator<T> where T : BaseAgeRating
    {
        public BaseAgeRatingValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
