using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BookImageUpdateValidator : AbstractValidator<UpdateBookImageRequestDTO>
    {
        public BookImageUpdateValidator()
        {
            
        }
    }
}
