using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CoverTypeUpdateValidator : AbstractValidator<UpdateCoverTypeRequestDTO>
    {
        public CoverTypeUpdateValidator()
        {
            Include(new BaseCoverTypeValidator<UpdateCoverTypeRequestDTO>());
        }
    }
}
