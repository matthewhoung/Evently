using Evently.Common.Domain.Abstractions.Errors;

namespace Evently.Common.Application.Abstractions.Exceptions;
public sealed class EventlyException : Exception
{
    public string RequestName { get; }
    public Error? Error { get; }

    public EventlyException(
        string requestName,
        Error? error = default,
        Exception? innerException = default)
        : base("Application exception", innerException)
    {
        RequestName = requestName;
        Error = error;
    }
}
