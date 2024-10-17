using Antree_Ecommerce_BE.API.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.API.Middlewares;
using Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Application.SignalR;
using Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Options;
using Antree_Ecommerce_BE.Persistence.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Persistence.DependencyInjection.Options;
using Carter;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http.Features;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration().ReadFrom
    .Configuration(builder.Configuration)
    .CreateLogger();

builder.Logging
    .ClearProviders()
    .AddSerilog();

builder.Host.UseSerilog();

// Add Carter module
builder.Services.AddCarter();

builder.Services
    .AddSwaggerGenNewtonsoftSupport()
    .AddFluentValidationRulesToSwagger()
    .AddEndpointsApiExplorer()
    .AddSwaggerAPI();

builder.Services
    .AddApiVersioning(options => options.ReportApiVersions = true)
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.ConfigureCors();

builder.Services.AddMediatRApplication();
builder.Services.AddAutoMapperApplication();
builder.Services.AddSignalRApplication();


builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = long.MaxValue;
    options.MultipartHeadersLengthLimit = int.MaxValue;
});

// Configure Options and SQL => Remember mapcarter
builder.Services.AddInterceptorPersistence();
builder.Services.ConfigureSqlServerRetryOptionsPersistence(builder.Configuration.GetSection(nameof(SqlServerRetryOptions)));
builder.Services.AddSqlServerPersistence();
builder.Services.AddRepositoryPersistence();

builder.Services.AddJwtAuthenticationAPI(builder.Configuration);
builder.Services.AddServicesInfrastructure();
builder.Services.AddRedisInfrastructure(builder.Configuration);
builder.Services.ConfigureCloudinaryOptionsInfrastucture(builder.Configuration.GetSection(nameof(CloudinaryOptions)));
builder.Services.ConfigureVnPayOptionsInfrastucture(builder.Configuration.GetSection(nameof(VnPayOption)));
builder.Services.ConfigureMailOptionsInfrastucture(builder.Configuration.GetSection(nameof(MailOption)));

builder.Services.AddHttpContextAccessor();
 
// Add Middleware => Remember using middleware
builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

// Using middleware
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapHub<PaymentHub>("/paymentHub");

// Configure the HTTP request pipeline. 
// if (builder.Environment.IsDevelopment() || builder.Environment.IsStaging())
    app.UseSwaggerAPI(); // => After MapCarter => Show Version

app.UseCors("CorsPolicy");

// app.UseHttpsRedirection();

app.UseAuthentication(); // Need to be before app.UseAuthorization();
// app.UseAntiforgery();
app.UseAuthorization();


// Add API Endpoint with carter module
app.MapCarter();

try
{
    await app.RunAsync();
    Log.Information("Stopped cleanly");
}
catch (Exception ex)
{
    Log.Fatal(ex, "An unhandled exception occured during bootstrapping");
    Console.WriteLine(ex.Message);
    await app.StopAsync();
}
finally
{
    Log.CloseAndFlush();
    await app.DisposeAsync();
}

public partial class Program { }