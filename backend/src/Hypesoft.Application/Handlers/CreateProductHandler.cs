using Hypesoft.Application.Commands.CreateProduct;
using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using Hypesoft.Application.Interfaces;
using MediatR;

namespace Hypesoft.Application.Handlers;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public CreateProductHandler(
        IProductRepository productRepository,
        ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var categoryExists = await _categoryRepository.ExistsAsync(request.CategoryId);
        if (!categoryExists)
            throw new Exception("Category does not exist");

        var product = Product.Create(request.Name, request.Price, request.CategoryId);
        await _productRepository.AddAsync(product);

        return product.Id;
    }
}
