using MongoDB.Driver;
using Hypesoft.Infrastructure.Persistence;
using Hypesoft.Application.Interfaces;
using Hypesoft.Domain.Entities;

namespace Hypesoft.Infrastructure.Repositories;
public class CategoryRepository : ICategoryRepository
{
    private readonly IMongoCollection<Category> _collection;

    public CategoryRepository(MongoDbContext context)
    {
        _collection = context.GetCollection<Category>("Categories");
    }

    public Task CreateAsync(Category category)
        => _collection.InsertOneAsync(category);

    public async Task<bool> ExistsAsync(Guid id)
{
    return await _collection
        .Find(c => c.Id == id)
        .AnyAsync();
}


    public Task<List<Category>> GetAllAsync()
        => _collection.Find(_ => true).ToListAsync();
}
