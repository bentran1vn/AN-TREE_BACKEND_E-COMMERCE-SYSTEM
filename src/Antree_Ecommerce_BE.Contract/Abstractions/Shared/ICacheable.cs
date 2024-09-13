namespace Antree_Ecommerce_BE.Contract.Abstractions.Shared;

public  interface ICacheable
{
    bool BypassCache { get; }
    string CacheKey { get; }
    // int SlidingExpirationInMinutes { get; }
    // int AbsoluteExpirationInMinutes { get; }
}