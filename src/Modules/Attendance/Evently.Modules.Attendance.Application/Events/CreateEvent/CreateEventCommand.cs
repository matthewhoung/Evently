using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Attendance.Application.Events.CreateEvent;

public sealed record CreateEventCommand(
    Guid EventId,
    string Title,
    string Description,
    string Location,
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc) : ICommand;

internal sealed class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
{
    public CreateEventCommandValidator()
    {
        RuleFor(c => c.EventId).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Location).NotEmpty();
        RuleFor(c => c.StartsAtUtc).NotEmpty();
        RuleFor(c => c.EndsAtUtc).Must((cmd, endsAt) => endsAt > cmd.StartsAtUtc).When(c => c.EndsAtUtc.HasValue);
    }
}
