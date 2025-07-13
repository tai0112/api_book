using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseCartDetailValidator<T> : AbstractValidator<T> where T :  BaseCartDetailDTO
    {
        public BaseCartDetailValidator()
        {
            RuleFor(o => o.CartId).NotEmpty();
            RuleFor(o => o.BookId).NotEmpty();
            RuleFor(o => o.PriceTotal).NotEmpty();
            RuleFor(o => o.Quantity).NotEmpty();
            RuleFor(o => o.PriceInit).NotEmpty();
        }
    }
}
