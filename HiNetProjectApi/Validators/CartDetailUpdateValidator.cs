using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CartDetailUpdateValidator : AbstractValidator<UpdateCartDetailRequestDTO>
    {
        public CartDetailUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseCartDetailValidator<UpdateCartDetailRequestDTO>());
        }
    }
}
