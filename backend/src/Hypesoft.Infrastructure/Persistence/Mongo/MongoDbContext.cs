using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Hypesoft.Infrastructure.Persistence;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;
    
    public MongoDbContext(IOptions<MongoSettings> options)
    {
        var client = new MongoClient(options.Value.ConnectionString);
        _database = client.GetDatabase("hypesoft");
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}
