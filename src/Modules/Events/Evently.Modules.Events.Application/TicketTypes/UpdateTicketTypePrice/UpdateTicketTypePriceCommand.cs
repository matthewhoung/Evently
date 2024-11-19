using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.TicketTypes.UpdateTicketTypePrice;
public sealed record class UpdateTicketTypePriceCommand(
    Guid TicketTypeId,
    decimal Price) : ICommand;

internal sealed class UpdateTicketTypePriceValidator : AbstractValidator<UpdateTicketTypePriceCommand>
{
    public UpdateTicketTypePriceValidator()
    {
        RuleFor(x => x.TicketTypeId).NotEmpty();
        RuleFor(x => x.Price).GreaterThan(decimal.Zero);
    }
}
