using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BookUpdateValidator : AbstractValidator<UpdateBookRequestDTO>
    {
        public BookUpdateValidator()
        {
            Include(new BaseBookValidator<  UpdateBookRequestDTO>());
        }
    }
}
