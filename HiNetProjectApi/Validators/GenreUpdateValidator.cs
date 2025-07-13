using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class GenreUpdateValidator : AbstractValidator<UpdateRequestGenreDTO>
    {
        public GenreUpdateValidator()
        {
            Include(new BaseGenreValidator<UpdateRequestGenreDTO>());
        }
    }
}
