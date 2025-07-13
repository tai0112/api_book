using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class OrderDetailUpdateValidator : AbstractValidator<UpdateOrderDetailRequestDTO>
    {
        public OrderDetailUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseOrderDetailValidator<UpdateOrderDetailRequestDTO>());
        }
    }
}
