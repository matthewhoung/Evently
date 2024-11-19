namespace Evently.Common.Application.Abstractions.Clock;

public interface IDateTimeProvider
{
    public DateTime UtcNow { get; }
}
