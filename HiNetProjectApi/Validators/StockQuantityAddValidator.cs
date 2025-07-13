using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class StockQuantityAddValidator : AbstractValidator<AddStockQuantityDTO>
    {
        public StockQuantityAddValidator()
        {
            Include(new BaseStockQuantityValidator<AddStockQuantityDTO>());
        }
    }
}
