using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseCoverTypeValidator<T> : AbstractValidator<T> where T : BaseCoverTypeDTO
    {
        public BaseCoverTypeValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
