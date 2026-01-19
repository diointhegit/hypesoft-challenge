using FluentValidation;
using Hypesoft.Application.Commands.CreateProduct;

namespace Hypesoft.Application.Commands.CreateProduct;

public class CreateProductValidator 
    : AbstractValidator<CreateProductCommand>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("O nome do produto é obrigatório.")
            .MinimumLength(3).WithMessage("O nome do produto deve ter pelo menos 3 caracteres.")
            .MaximumLength(100).WithMessage("O nome do produto pode ter no máximo 100 caracteres.");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("O preço do produto deve ser maior que zero.");

        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("O ID da categoria é obrigatório.");
    }
}
