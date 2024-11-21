using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.TicketTypes.UpdateTicketTypePrice;

public sealed record UpdateTicketTypePriceCommand(Guid TicketTypeId, decimal Price) : ICommand;

internal sealed class UpdateTicketTypePriceCommandValidator : AbstractValidator<UpdateTicketTypePriceCommand>
{
    public UpdateTicketTypePriceCommandValidator()
    {
        RuleFor(c => c.TicketTypeId).NotEmpty();
        RuleFor(c => c.Price).GreaterThan(decimal.Zero);
    }
}

