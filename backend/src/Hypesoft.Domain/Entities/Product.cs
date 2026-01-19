using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hypesoft.Domain.Entities;

public class Product
{
  [BsonId]
    [BsonRepresentation(BsonType.Binary)]
    [BsonGuidRepresentation(GuidRepresentation.Standard)]
    public Guid Id { get; private set; }

    public Guid CategoryId { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    private Product() { }

    public static Product Create(string name, decimal price, Guid categoryId)
    {
        return new Product
        {
            Id = Guid.NewGuid(),
            Name = name,
            Price = price,
            CategoryId = categoryId
        };
    }
}
