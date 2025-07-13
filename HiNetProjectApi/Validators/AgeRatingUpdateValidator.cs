using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class AgeRatingUpdateValidator : AbstractValidator<UpdateRequestAgeRatingDTO>
    {
        public AgeRatingUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseAgeRatingValidator<UpdateRequestAgeRatingDTO>());
        }
    }
}
