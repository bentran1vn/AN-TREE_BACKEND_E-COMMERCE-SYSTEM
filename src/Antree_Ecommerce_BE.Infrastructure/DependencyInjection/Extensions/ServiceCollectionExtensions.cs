using Antree_Ecommerce_BE.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Antree_Ecommerce_BE.Infrastructure.Authentication;
using Antree_Ecommerce_BE.Infrastructure.Caching;
using Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Options;
using Antree_Ecommerce_BE.Infrastructure.Media;
using CloudinaryDotNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddServicesInfrastructure(this IServiceCollection services)
        => services.AddTransient<IJwtTokenService, JwtTokenService>()
        .AddTransient<ICacheService, CacheService>()
        .AddSingleton<IMediaService, CloudinaryService>()
        .AddSingleton<Cloudinary>((provider) =>
        {
            var options = provider.GetRequiredService<IOptionsMonitor<CloudinaryOptions>>();
            return new Cloudinary(new Account(
                options.CurrentValue.CloudName,
                options.CurrentValue.ApiKey,
                options.CurrentValue.ApiSecret));
        });
    
    public static void AddRedisInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddStackExchangeRedisCache(redisOptions =>
        {
            var connectionString = configuration.GetConnectionString("Redis");
            redisOptions.Configuration = connectionString;
        });
    }
    
    public static OptionsBuilder<CloudinaryOptions> ConfigureCloudinaryOptionsInfrastucture(this IServiceCollection services, IConfigurationSection section)
        => services
            .AddOptions<CloudinaryOptions>()
            .Bind(section)
            .ValidateDataAnnotations()
            .ValidateOnStart();
}