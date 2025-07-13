using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseStockQuantityValidator<T> : AbstractValidator<T> where T : BaseStockQuantityDTO
    {
        public BaseStockQuantityValidator()
        {
            RuleFor(o => o.Quantities).NotEmpty().GreaterThan(-1);
            RuleFor(o => o.BookId).NotEmpty();
        }
    }
}
