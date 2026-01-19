using Hypesoft.Domain.Entities;
using MediatR;

namespace Hypesoft.Application.Queries.GetCategories;

public class GetCategoriesQuery : IRequest<List<Category>>
{
}
