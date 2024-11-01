using Microsoft.Extensions.DependencyInjection;

namespace Aggregate.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}