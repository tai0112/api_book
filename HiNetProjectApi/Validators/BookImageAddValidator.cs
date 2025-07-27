using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BookImageAddValidator : AbstractValidator<AddBookImageRequestDTO>
    {
        public BookImageAddValidator()
        {
            RuleFor(x => x.File).NotEmpty();
            RuleFor(x => x.BookId).NotEmpty();
        }
    }
}
