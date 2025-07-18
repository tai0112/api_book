using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class PublisherUpdateValidator : AbstractValidator<UpdatePublisherRequestDTO>
    {
        public PublisherUpdateValidator()
        {   
            Include(new BasePublisherValidator<UpdatePublisherRequestDTO>());
        }
    }
}
