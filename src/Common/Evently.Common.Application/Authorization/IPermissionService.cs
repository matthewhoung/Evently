using Evently.Common.Domain.Abstractions.Results;

namespace Evently.Common.Application.Authorization;

public interface IPermissionService
{
    Task<Result<PermissionsResponse>> GetUserPermissionsAsync(string identityId);
}
