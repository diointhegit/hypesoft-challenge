using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Hypesoft.Infrastructure.Persistence;

public static class MongoBootstrap
{
    private static bool _initialized;

    public static void Initialize()
    {
        if (_initialized)
            return;

        // Define o padrão de Guid
        BsonSerializer.RegisterSerializer(
            new GuidSerializer(GuidRepresentation.Standard)
        );

        _initialized = true;
    }
}
