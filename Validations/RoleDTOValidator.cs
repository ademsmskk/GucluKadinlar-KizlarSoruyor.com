using FluentValidation;

public class RoleDTOValidator : AbstractValidator<Role>
{
    public RoleDTOValidator()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("Rol adı alanı boş geçilemez.");
        

    }
}