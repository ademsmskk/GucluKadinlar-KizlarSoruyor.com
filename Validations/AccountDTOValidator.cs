using FluentValidation;

public class AccountDTOValidator : AbstractValidator<Account>
{
    public AccountDTOValidator()
    {
        RuleFor(x => x.Email).NotNull().WithMessage("Email alanı boş geçilemez.");
        RuleFor(x => x.Password).NotNull().WithMessage("Şifre alanı boş geçilemez.");

    }
}