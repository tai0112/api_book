using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class PublisherAddValidator : AbstractValidator<AddPublisherRequestDTO>
    {
        public PublisherAddValidator()
        {
            Include(new BasePublisherValidator<AddPublisherRequestDTO>());
        }
    }
}
