using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class AgeRatingAddValidator : AbstractValidator<AddAgeRatingRequestDTO>
    {
        public AgeRatingAddValidator()
        {
            Include(new BaseAgeRatingValidator<AddAgeRatingRequestDTO>());
        }
    }
}
