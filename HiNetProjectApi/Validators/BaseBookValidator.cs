using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BaseBookValidator<T> : AbstractValidator<T> where T : BaseBookDTO
    {
        public BaseBookValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
            RuleFor(o => o.AgeRatingId).NotEmpty();
            RuleFor(o => o.Author).NotEmpty();
            RuleFor(o => o.Code).NotEmpty();
            RuleFor(o => o.CoverTypeId).NotEmpty();
            RuleFor(o => o.Height).NotEmpty();
            RuleFor(o => o.Weight).NotEmpty();
            RuleFor(o => o.Witdh).NotEmpty();
            RuleFor(o => o.Language).NotEmpty();
            RuleFor(o => o.PriceInit).NotEmpty();
            RuleFor(o => o.PageTotal).NotEmpty();
            RuleFor(o => o.PublisherId).NotEmpty();
            RuleFor(o => o.SubGenreId).NotEmpty();
            RuleFor(o => o.YearPublish).NotEmpty();
        }
    }
}
