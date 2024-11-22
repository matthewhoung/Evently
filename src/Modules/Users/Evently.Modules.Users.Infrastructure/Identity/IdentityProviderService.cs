using System.Net;
using Evently.Common.Domain.Abstractions.Results;
using Evently.Modules.Users.Application.Abstractions.Identity;
using Microsoft.Extensions.Logging;

namespace Evently.Modules.Users.Infrastructure.Identity;
internal sealed class IdentityProviderService(
    KeyCloakClient keyCloakClient,
    ILogger<IdentityProviderService> logger) 
    : IIdentityProviderService
{
    private const string PasswordCredentialType = "Password";
    // POST /admin/realms/{realm}/users
    public async Task<Result<string>> RegisterUserAsync(
        UserModel user, 
        CancellationToken cancellationToken = default)
    {
        var userRepresentation = new UserRepresentation(
            user.Email,
            user.Email,
            user.FirstName,
            user.LastName,
            true,
            true,
            [new CredentialRepresentation(PasswordCredentialType, user.Password, false)]);

        // Call Keycloak API to create a new user
        try
        {
            string identityId = await keyCloakClient.RegisterUserAsync(userRepresentation, cancellationToken);

            return identityId;
        }
        catch (HttpRequestException exception) 
        when (exception.StatusCode == HttpStatusCode.Conflict)
        {
            logger.LogError(exception, "User registration failed");

            return Result.Failure<string>(IdentityProviderErrors.EmailIsNotUnique);
        }
    }
}

internal sealed record UserRepresentation(
    string Username,
    string Eamil,
    string FirstName,
    string LastName,
    bool EmailVerified,
    bool Enabled,
    CredentialRepresentation[] Credentials);

internal sealed record CredentialRepresentation(
    string Type,
    string Value,
    bool Temporary);
