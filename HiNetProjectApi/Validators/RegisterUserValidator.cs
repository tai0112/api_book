using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserRequestDTO>
    {
        public RegisterUserValidator()
        {
            RuleFor(o => o.Email).NotEmpty().EmailAddress();
            RuleFor(o => o.FullName).NotEmpty();
            RuleFor(o => o.UserName).NotEmpty();
            RuleFor(o => o.Password).NotEmpty();
            RuleFor(o => o.RePassword).NotEmpty().Equal(o => o.Password);
        }
    }
}
