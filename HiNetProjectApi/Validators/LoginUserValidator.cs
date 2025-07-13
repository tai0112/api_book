using FluentValidation;
using HiNetProjectApi.Models.DTO;

namespace HiNetProjectApi.Validators
{
    public class LoginUserValidator : AbstractValidator<LoginUserRequestDTO>
    {
        public LoginUserValidator()
        {
            RuleFor(o => o.UserName).NotEmpty();
            RuleFor(o => o.Password).NotEmpty();    
        }
    }
}
