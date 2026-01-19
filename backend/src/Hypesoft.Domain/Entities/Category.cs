using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Hypesoft.Domain.Entities;

public class Category
{

    [BsonId]
    [BsonRepresentation(BsonType.Binary)]
    [BsonGuidRepresentation(GuidRepresentation.Standard)]
    public Guid Id { get; private set; }
    public string Name { get; private set; }

    public Category(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }
}
