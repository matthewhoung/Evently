using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Attendance.Application.Attendees.CreateAttendee;

public sealed record CreateAttendeeCommand(
    Guid AttendeeId, 
    string Email, 
    string FirstName, 
    string LastName)
    : ICommand;

internal sealed class CreateAttendeeCommandValidator : AbstractValidator<CreateAttendeeCommand>
{
    public CreateAttendeeCommandValidator()
    {
        RuleFor(c => c.AttendeeId).NotEmpty();
        RuleFor(c => c.Email).EmailAddress();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
    }
}
