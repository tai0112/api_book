using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class OrderAddValidator : AbstractValidator<AddOrderRequestDTO>
    {
        public OrderAddValidator()
        {
            RuleFor(o => o.CreateAt).NotEmpty();
            Include(new BaseOrderValidator<AddOrderRequestDTO>());
        }
    }
}
