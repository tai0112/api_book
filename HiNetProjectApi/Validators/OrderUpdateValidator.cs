using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class OrderUpdateValidator : AbstractValidator<UpdateOrderRequestDTO>
    {
        public OrderUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseOrderValidator<UpdateOrderRequestDTO>());
        }
    }
}
