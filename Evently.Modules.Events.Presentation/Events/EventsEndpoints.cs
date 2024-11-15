using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Events;
public static class EventsEndpoints
{
    // Register endpoints within EventsEndpoints
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        CreateEvent.MapEndpoint(app);
        GetEvent.MapEndpoint(app);
    }
}
