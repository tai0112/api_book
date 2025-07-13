using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseOrderDetailValidator<T> : AbstractValidator<T> where T : BaseOrderDetailDTO
    {
        public BaseOrderDetailValidator()
        {
            RuleFor(o => o.OrderId).NotEmpty();
            RuleFor(o => o.Quantity).NotEmpty();
            RuleFor(o => o.BookId).NotEmpty();
            RuleFor(o => o.PriceInit).NotEmpty();
            RuleFor(o => o.PriceTotal).NotEmpty();
        }
    }
}
