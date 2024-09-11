using Antree_Ecommerce_BE.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Antree_Ecommerce_BE.Infrastructure.Authentication;
using Antree_Ecommerce_BE.Infrastructure.Caching;
using Microsoft.Extensions.Configuration;

namespace Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddServicesInfrastructure(this IServiceCollection services)
        => services.AddTransient<IJwtTokenService, JwtTokenService>()
        .AddTransient<ICacheService, CacheService>();
    
    public static void AddRedisInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddStackExchangeRedisCache(redisOptions =>
        {
            var connectionString = configuration.GetConnectionString("Redis");
            redisOptions.Configuration = connectionString;
        });
    }
}