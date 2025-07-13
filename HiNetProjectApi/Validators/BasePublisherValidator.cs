using FluentValidation;
using HiNetProjectApi.Models.Domain;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class BasePublisherValidator<T> : AbstractValidator<T> where T : BasePublisherDTO
    {
        public BasePublisherValidator()
        {
            RuleFor(o => o.Name).NotEmpty();
        }
    }
}
