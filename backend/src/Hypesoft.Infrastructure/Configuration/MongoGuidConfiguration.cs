using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Hypesoft.Infrastructure.Persistence;

public static class MongoGuidConfiguration
{
    private static bool _configured;

    public static void Configure()
    {
        if (_configured) return;

        // BsonSerializer.RegisterSerializer(
        //     new GuidSerializer(GuidRepresentation.Standard)
        // );

        _configured = true;
    }
}
