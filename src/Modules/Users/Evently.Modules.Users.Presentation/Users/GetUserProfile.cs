﻿using System.Security.Claims;
using Evently.Common.Domain.Abstractions.Results;
using Evently.Common.Infrastructure.Authentication;
using Evently.Common.Presentation.EndPoints;
using Evently.Modules.Events.Presentation.ApiResults;
using Evently.Modules.Users.Application.Users.GetUser;
using Evently.Modules.Users.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Users.Presentation.Users;
internal sealed class GetUserProfile : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("users/profile", async (ClaimsPrincipal claims, ISender sender) =>
        {
            Result<UserResponse> result = await sender.Send(new GetUserQuery(claims.GetUserId()));

            return result.Match(
                Results.Ok,
                ApiResults.Problem);
        })
        .RequireAuthorization(Permission.GetUser.Code)
        .WithTags(Tags.Users);
    }
}
