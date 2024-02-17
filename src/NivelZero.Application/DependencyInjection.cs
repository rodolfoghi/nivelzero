using Microsoft.Extensions.DependencyInjection;
using NivelZero.Application.Tenants;

namespace NivelZero.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ITenantAppService, TenantAppService>();
        return services;
    }
}