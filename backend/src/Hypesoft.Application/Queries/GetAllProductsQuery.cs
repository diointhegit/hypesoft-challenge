using Hypesoft.Domain.Entities;
using MediatR;

namespace Hypesoft.Application.Queries.GetProducts;

public class GetAllProductsQuery : IRequest<List<Product>>;
