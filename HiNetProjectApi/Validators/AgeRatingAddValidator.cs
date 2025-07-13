using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class AgeRatingAddValidator : AbstractValidator<AddRequestAgeRatingDTO>
    {
        public AgeRatingAddValidator()
        {
            Include(new BaseAgeRatingValidator<AddRequestAgeRatingDTO>());
        }
    }
}
