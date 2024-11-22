namespace Evently.Modules.Users.Infrastructure.Identity;

internal sealed record UserRepresentation(
    string Username,
    string Eamil,
    string FirstName,
    string LastName,
    bool EmailVerified,
    bool Enabled,
    CredentialRepresentation[] Credentials);
