using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CartUpdateValidator : AbstractValidator<UpdateCartRequestDTO>
    {
        public CartUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseCartValidator<UpdateCartRequestDTO>());
        }
    }
}
