using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Attendance.Application.Tickets.CreateTicket;

public sealed record CreateTicketCommand(
    Guid TicketId, 
    Guid AttendeeId, 
    Guid EventId, 
    string Code) 
    : ICommand;

internal sealed class CreateTicketCommandValidator : AbstractValidator<CreateTicketCommand>
{
    public CreateTicketCommandValidator()
    {
        RuleFor(c => c.TicketId).NotEmpty();
        RuleFor(c => c.AttendeeId).NotEmpty();
        RuleFor(c => c.EventId).NotEmpty();
        RuleFor(c => c.Code).NotEmpty();
    }
}
