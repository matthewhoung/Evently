using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.Events.RescheduleEvent;
public record class RescheduleEventCommand(
    Guid EventId, 
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc) : ICommand;

internal sealed class RescheduleEventCommandValidator : AbstractValidator<RescheduleEventCommand>
{
    public RescheduleEventCommandValidator()
    {
        RuleFor(x => x.EventId).NotEmpty();
        RuleFor(x => x.StartsAtUtc).NotEmpty();
        RuleFor(x => x.EndsAtUtc).Must((cmd, endsAt) => endsAt > cmd.StartsAtUtc)
                                 .When(x => x.EndsAtUtc.HasValue);
    }
}
