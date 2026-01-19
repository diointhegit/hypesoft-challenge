using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using Hypesoft.Infrastructure.Persistence;
using MongoDB.Driver;

namespace Hypesoft.Infrastructure.Repositories;

public class ProductRepository : IProductRepository   
{
    private readonly MongoDbContext _context;

    public ProductRepository(MongoDbContext context)
    {
        _context = context;
    }

    private IMongoCollection<Product> Collection => _context.GetCollection<Product>("Products");

    public async Task AddAsync(Product product)
        => await Collection.InsertOneAsync(product);

    public async Task<Product?> GetByIdAsync(Guid id)
        => await Collection.Find(p => p.Id == id).FirstOrDefaultAsync();

    public async Task<List<Product>> GetAllAsync()
        => await Collection.Find(_ => true).ToListAsync();

    public async Task<bool> ExistsAsync(Guid id)
        => await Collection.Find(p => p.Id == id).AnyAsync();
}
