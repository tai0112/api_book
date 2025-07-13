using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class SubGenreUpdateValidator : AbstractValidator<UpdateSubGenreRequestDTO>
    {
        public SubGenreUpdateValidator()
        {
            Include(new BaseSubGenreValidator<UpdateSubGenreRequestDTO>());
        }
    }
}
