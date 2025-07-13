using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class OrderDetailAddValidator : AbstractValidator<AddOrderDetailRequestDTO>
    {
        public OrderDetailAddValidator()
        {
            Include(new BaseOrderDetailValidator<AddOrderDetailRequestDTO>());
        }
    }
}
