using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Payments.RefundPaymentsForEvent;

public sealed record RefundPaymentsForEventCommand(Guid EventId) : ICommand;

internal sealed class RefundPaymentsForEventCommandValidator : AbstractValidator<RefundPaymentsForEventCommand>
{
    public RefundPaymentsForEventCommandValidator()
    {
        RuleFor(c => c.EventId).NotEmpty();
    }
}
