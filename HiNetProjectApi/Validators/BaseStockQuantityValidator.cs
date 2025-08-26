using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseStockQuantityValidator<T> : AbstractValidator<T> where T : BaseStockQuantityDTO
    {
        public BaseStockQuantityValidator()
        {
            RuleFor(o => o.Quantities).GreaterThan(-1);
            RuleFor(o => o.BookId).NotEmpty();
        }
    }
}
