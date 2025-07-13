using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CartAddValidator : AbstractValidator<AddCartRequestDTO>
    {
        public CartAddValidator()
        {
            Include(new BaseCartValidator<AddCartRequestDTO>());
        }
    }
}
