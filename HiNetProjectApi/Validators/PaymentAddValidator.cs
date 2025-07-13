using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class PaymentAddValidator : AbstractValidator<AddPaymentRequestDTO>
    {
        public PaymentAddValidator()
        {
            Include(new BasePaymentValidator<AddPaymentRequestDTO>());
        }
    }
}
