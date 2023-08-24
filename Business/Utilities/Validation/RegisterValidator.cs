using Business.Models.Request.Functional;
using FluentValidation;

namespace Business.Utilities.Validation;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(x => x.tc_no).NotEmpty().WithName("Tc no").MinimumLength(5).MaximumLength(11);
        RuleFor(x => x.UserName).NotEmpty().WithName("Kullanıcı Adı").MinimumLength(5);
        RuleFor(x => x.Email).NotEmpty().WithName("E-Mail").MinimumLength(8);
        RuleFor(x => x.phone).NotEmpty().WithName("Telefon").MinimumLength(5).MaximumLength(10);
        RuleFor(x => x.Password).NotEmpty().WithName("Şifre").MinimumLength(8);
    }
}