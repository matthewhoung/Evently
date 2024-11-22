using Evently.Common.Domain.Abstractions.Results;

namespace Evently.Modules.Users.Application.Abstractions.Identity;
public interface IIdentityProviderService
{
    Task<Result<string>> RegisterUserAsync(UserModel user, CancellationToken cancellationToken = default);
}
