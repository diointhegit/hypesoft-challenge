using Hypesoft.Application.Interfaces;
using Hypesoft.Application.Queries.GetProducts;
using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using MediatR;

namespace Hypesoft.Application.Queries.GetCategories;

public class GetProductsHandler
    : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        return await _productRepository.GetAllAsync();
    }
}
 