using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class StockQuantityUpdateValidator : AbstractValidator<UpdateStockQuantityRequestDTO>
    {
        public StockQuantityUpdateValidator()
        {
            RuleFor(o => o.Id).NotEmpty();
            Include(new BaseStockQuantityValidator<UpdateStockQuantityRequestDTO>());
        }
    }
}
