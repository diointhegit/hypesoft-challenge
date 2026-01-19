using Hypesoft.Infrastructure.Repositories;
using Hypesoft.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Hypesoft.Application.Interfaces;
using Hypesoft.Domain.Repositories;

namespace Hypesoft.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<MongoSettings>(
            configuration.GetSection("Mongo")
        );
        MongoGuidConfiguration.Configure();
        services.AddScoped<MongoDbContext>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>(); 
        return services;
    }
}
