using FluentValidation;

public class CategoryDTOValidator : AbstractValidator<Category>
{
    public CategoryDTOValidator()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("Kategori adı alanı boş geçilemez.");
        

    }
}