using Microsoft.AspNetCore.Routing;

namespace Evently.Common.Presentation.EndPoints;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}
