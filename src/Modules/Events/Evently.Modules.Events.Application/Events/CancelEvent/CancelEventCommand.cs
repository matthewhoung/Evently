using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.Events.CancelEvent;
public sealed record class CancelEventCommand(Guid EventId) : ICommand;

internal sealed class CancelEventCommandValidator : AbstractValidator<CancelEventCommand>
{
    public CancelEventCommandValidator()
    {
        RuleFor(x => x.EventId).NotEmpty();
    }
}
