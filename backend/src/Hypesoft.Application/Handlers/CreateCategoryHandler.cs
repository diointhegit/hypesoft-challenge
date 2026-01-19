using MediatR;
using Hypesoft.Application.Interfaces;
using Hypesoft.Domain.Entities;

namespace Hypesoft.Application.Commands.CreateCategory;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Guid>
{
    private readonly ICategoryRepository _repository;

    public CreateCategoryHandler(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category(request.Name);
        await _repository.CreateAsync(category);
        return category.Id;
    }
}
