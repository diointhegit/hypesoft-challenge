using FluentValidation;
using Hypesoft.Application.Commands.CreateCategory;

namespace Hypesoft.Application.Commands.CreateCategory;

public class CreateCategoryValidator 
    : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("O nome da categoria é obrigatório.")
            .MinimumLength(3).WithMessage("O nome da categoria deve ter pelo menos 3 caracteres.")
            .MaximumLength(50).WithMessage("O nome da categoria pode ter no máximo 50 caracteres.");
    }
}
