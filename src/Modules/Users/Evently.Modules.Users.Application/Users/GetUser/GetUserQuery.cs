using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Users.Application.Users.GetUser;
public sealed record class GetUserQuery(Guid UserId) : IQuery<UserResponse>;

public sealed record UserResponse(
    Guid Id, 
    string Email, 
    string FirstName, 
    string LastName);
