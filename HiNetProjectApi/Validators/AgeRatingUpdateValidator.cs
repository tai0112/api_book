using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class AgeRatingUpdateValidator : AbstractValidator<UpdateRequestAgeRatingDTO>
    {
        public AgeRatingUpdateValidator()
        {
            Include(new BaseAgeRatingValidator<UpdateRequestAgeRatingDTO>());
        }
    }
}
