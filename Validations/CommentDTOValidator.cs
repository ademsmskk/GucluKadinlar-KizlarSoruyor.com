using FluentValidation;

public class CommentDTOValidator : AbstractValidator<Comment>
{
    public CommentDTOValidator()
    {
        RuleFor(x => x.Content).NotNull().WithMessage("Yorum içeriği alanı boş geçilemez.");
        

    }
}