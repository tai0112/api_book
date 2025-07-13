using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CoverTypeUpdateValidator : AbstractValidator<UpdateCoverTypeRequestDTO>
    {
        public CoverTypeUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseCoverTypeValidator<UpdateCoverTypeRequestDTO>());
        }
    }
}
