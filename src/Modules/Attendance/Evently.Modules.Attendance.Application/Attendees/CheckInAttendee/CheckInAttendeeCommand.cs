using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Attendance.Application.Attendees.CheckInAttendee;

public sealed record CheckInAttendeeCommand(Guid AttendeeId, Guid TicketId) : ICommand;

internal sealed class CheckInAttendeeCommandValidator : AbstractValidator<CheckInAttendeeCommand>
{
    public CheckInAttendeeCommandValidator()
    {
        RuleFor(c => c.TicketId).NotEmpty();
    }
}
