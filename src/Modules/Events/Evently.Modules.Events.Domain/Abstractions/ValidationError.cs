using Evently.Modules.Abstractions.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Abstractions;
public sealed record class ValidationError : Error
{
    public Error[] Errors { get; }

    public ValidationError(Error[] errors)
        : base("General.ValidationError",
               "One or more validation errors occurred",
               ErrorType.Validation)
    {
        Errors = errors;
    }

    public static ValidationError FromResults(IEnumerable<Result> results) =>
        new(results.Where(r => r.IsFailure).Select(r => r.Error).ToArray());
}
