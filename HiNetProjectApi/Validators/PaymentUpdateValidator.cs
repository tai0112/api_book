using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class PaymentUpdateValidator : AbstractValidator<UpdatePaymentRequestDTO>
    {
        public PaymentUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BasePaymentValidator<UpdatePaymentRequestDTO>());
        }
    }
}
