using Evently.Modules.Events.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.Events.PublishEvent;
public sealed record class PublishEventCommand(Guid EventId) : ICommand;

internal sealed class PublishEventCommandValidator : AbstractValidator<PublishEventCommand>
{
    public PublishEventCommandValidator()
    {
        RuleFor(x => x.EventId).NotEmpty();
    }
}
