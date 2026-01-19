using Hypesoft.Domain.Entities;

namespace Hypesoft.Application.Interfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllAsync();
    Task<bool> ExistsAsync(Guid id);    Task CreateAsync(Category category);
}
