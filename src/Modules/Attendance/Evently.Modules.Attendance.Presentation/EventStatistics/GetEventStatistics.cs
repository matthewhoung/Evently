using Evently.Common.Domain.Abstractions.Results;
using Evently.Common.Presentation.EndPoints;
using Evently.Common.Presentation.Results;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Attendance.Presentation.EventStatistics;

internal sealed class GetEventStatistics : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("event-statistics/{id}", async (Guid id, ISender sender) =>
        {
            Result<EventStatisticsResponse> result = await sender.Send(new GetEventStatisticsQuery(id));

            return result.Match(Results.Ok, ApiResults.Problem);
        })
        .RequireAuthorization(Permissions.GetEventStatistics)
        .WithTags(Tags.EventStatistics);
    }
}
