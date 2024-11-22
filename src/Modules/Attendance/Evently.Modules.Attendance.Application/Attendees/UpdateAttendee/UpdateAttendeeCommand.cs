using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Attendance.Application.Attendees.UpdateAttendee;

public sealed record UpdateAttendeeCommand(
    Guid AttendeeId, 
    string FirstName, 
    string LastName) 
    : ICommand;

internal sealed class UpdateAttendeeCommandValidator : AbstractValidator<UpdateAttendeeCommand>
{
    public UpdateAttendeeCommandValidator()
    {
        RuleFor(c => c.AttendeeId).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
    }
}
