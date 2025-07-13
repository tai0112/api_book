using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CoverTypeAddValidator : AbstractValidator<AddCoverTypeRequestDTO>
    {
        public CoverTypeAddValidator()
        {
            Include(new BaseCoverTypeValidator<AddCoverTypeRequestDTO>());
        }
    }
}
