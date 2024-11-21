using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Carts.AddItemToCart;
public sealed record class AddItemToCartCommand(
    Guid CustomerId,
    Guid TicketTypeId,
    decimal Quantity) : ICommand;

internal sealed class AddItemToCartCommandValidation : AbstractValidator<AddItemToCartCommand>
{
    public AddItemToCartCommandValidation()
    {
        RuleFor(c => c.CustomerId).NotEmpty();
        RuleFor(c => c.TicketTypeId).NotEmpty();
        RuleFor(c => c.Quantity).GreaterThan(decimal.Zero);
    }
}
