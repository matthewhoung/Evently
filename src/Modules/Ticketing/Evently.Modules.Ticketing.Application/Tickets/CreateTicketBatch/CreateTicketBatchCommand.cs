using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Tickets.CreateTicketBatch;

public sealed record CreateTicketBatchCommand(Guid OrderId) : ICommand;

internal sealed class CreateTicketBatchCommandValidator : AbstractValidator<CreateTicketBatchCommand>
{
    public CreateTicketBatchCommandValidator()
    {
        RuleFor(c => c.OrderId).NotEmpty();
    }
}
