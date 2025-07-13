using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class CartDetailAddValidator : AbstractValidator<AddCartDetailRequestDTO>
    {
        public CartDetailAddValidator()
        {
            Include(new BaseCartDetailValidator<AddCartDetailRequestDTO>());
        }
    }
}
