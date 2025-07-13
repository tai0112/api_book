using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class PublisherUpdateValidator : AbstractValidator<UpdatePublisherRequestDTO>
    {
        public PublisherUpdateValidator()
        {   
            RuleFor(o => o.Id).NotEmpty();
            Include(new BasePublisherValidator<UpdatePublisherRequestDTO>());
        }
    }
}
