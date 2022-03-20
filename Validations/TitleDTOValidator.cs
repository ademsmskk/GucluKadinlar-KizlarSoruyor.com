using FluentValidation;

public class TitleDTOValidator : AbstractValidator<Title>
{
    public TitleDTOValidator()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("Başlık adı alanı boş geçilemez.");
        

    }
}