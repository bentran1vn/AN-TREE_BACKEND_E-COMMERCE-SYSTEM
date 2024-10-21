using Antree_Ecommerce_BE.Application.Behaviors;
using Antree_Ecommerce_BE.Application.Mapper;
using Antree_Ecommerce_BE.Application.SignalR;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediatRApplication(this IServiceCollection services)
        => services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(AssemblyReference.Assembly)
            )
            // .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationDefaultBehavior<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformancePipelineBehavior<,>))
            .AddTransient(typeof(IPipelineBehavior<,>),typeof(CachingPipelineBehaviorCachingBehavior<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionPipelineBehavior<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(TracingPipelineBehavior<,>))
            .AddValidatorsFromAssembly(Contract.AssemblyReference.Assembly, includeInternalTypes: true);

    public static IServiceCollection AddAutoMapperApplication(this IServiceCollection services)
        => services.AddAutoMapper(typeof(ServiceProfile));

    public static void AddSignalRApplication(this IServiceCollection services)
        => services
            .AddTransient<PaymentService>();
}