
using FluentValidation;

public class PostDTOValidator : AbstractValidator<Post>
{
    public PostDTOValidator()
    {
        RuleFor(x => x.Content).NotNull().WithMessage("Gönderi içeriği alanı boş geçilemez.");
        

    }
}