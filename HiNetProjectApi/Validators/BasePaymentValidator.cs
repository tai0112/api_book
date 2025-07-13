using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BasePaymentValidator<T> : AbstractValidator<T> where T : BasePaymentDTO
    {
        public BasePaymentValidator()
        {
            RuleFor(o => o.PriceTotal).NotEmpty();
            RuleFor(o => o.OderId).NotEmpty();
            RuleFor(o => o.UserId).NotEmpty();
        }
    }
}
