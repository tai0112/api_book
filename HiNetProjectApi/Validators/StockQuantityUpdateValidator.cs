using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class StockQuantityUpdateValidator : AbstractValidator<UpdateStockQuantityRequestDTO>
    {
        public StockQuantityUpdateValidator()
        {
            Include(new BaseStockQuantityValidator<UpdateStockQuantityRequestDTO>());
        }
    }
}
