using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Evently.Common.Presentation.EndPoints;
using Evently.Modules.Ticketing.Application.Carts;

namespace Evently.Modules.Ticketing.Infrastructure;

public static class TicketingModule
{
    public static IServiceCollection AddTicketingModule(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddInfrastructure(configuration);

        services.AddEndpoints(Presentation.AssemblyReference.Assembly);

        return services;
    }

    private static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<CartService>();
    }
}
