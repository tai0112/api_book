using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BookAddValidator : AbstractValidator<AddBookRequestDTO>
    {
        public BookAddValidator()
        {
            Include(new BaseBookValidator<AddBookRequestDTO>());
        }
    }
}
