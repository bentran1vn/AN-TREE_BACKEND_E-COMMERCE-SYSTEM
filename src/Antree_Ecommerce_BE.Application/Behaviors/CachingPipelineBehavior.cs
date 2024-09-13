using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Antree_Ecommerce_BE.Application.Behaviors;

public class CachingPipelineBehaviorCachingBehavior<TRequest, TResponse>(
    ICacheService cacheService
)
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : ICacheable 
    where TResponse : Result
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        TResponse response;
        // By Pass Cache
        if (request.BypassCache) return await next();
        async Task<TResponse> GetResponseAndAddToCache()
        {
            response = await next();
            if (response != null)
            {
                await cacheService.SetAsync(request.CacheKey, response, cancellationToken);
            }
            return response;
        }
        var cachedResponse = await cacheService.GetAsync<TResponse>(request.CacheKey, cancellationToken);
        
        // Take In Cache
            // Exist => Return
            // Not Exist => Persist, UpdateCache
        if (cachedResponse != null)
        {
            response = cachedResponse;
            // logger.LogInformation("fetched from cache with key : {CacheKey}", request.CacheKey);
        }
        else
        {
            response = await GetResponseAndAddToCache();
            // logger.LogInformation("added to cache with key : {CacheKey}", request.CacheKey);
        }
        return response;
    }
}