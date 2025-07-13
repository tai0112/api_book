using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseOrderValidator<T> : AbstractValidator<T> where T: BaseOrderDTO
    {
        public BaseOrderValidator()
        {
            RuleFor(o => o.UserId).NotEmpty();
            RuleFor(o => o.Status).NotEmpty();
        }
    }
}
