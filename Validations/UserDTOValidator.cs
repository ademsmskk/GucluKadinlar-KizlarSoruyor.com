using FluentValidation;

public class UserDTOValidator : AbstractValidator<User>
{
    public UserDTOValidator()
    {
        RuleFor(x => x.FirstName).NotNull().WithMessage("İsim alanı boş geçilemez.");
        RuleFor(x => x.LastName).NotNull().WithMessage("Soyisim alanı boş geçilemez.");
        RuleFor(x => x.Username).NotNull().WithMessage("Kullanıcı adı alanı boş geçilemez.");

    }
}