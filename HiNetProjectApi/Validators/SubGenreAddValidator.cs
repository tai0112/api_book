using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class SubGenreAddValidator : AbstractValidator<AddSubGenreRequestDTO>
    {
        public SubGenreAddValidator()
        {
            Include(new BaseSubGenreValidator<AddSubGenreRequestDTO>());
        }
    }
}
