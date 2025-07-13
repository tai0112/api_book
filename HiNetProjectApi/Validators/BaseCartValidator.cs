using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseCartValidator<T> : AbstractValidator<T> where T : BaseCartDTO
    {
        public BaseCartValidator()
        {
            RuleFor(o => o.UserId).NotEmpty();
            RuleFor(o => o.TotalPrice).NotNull();
        }
    }
}
