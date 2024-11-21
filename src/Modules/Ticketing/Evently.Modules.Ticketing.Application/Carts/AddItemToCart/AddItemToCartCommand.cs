using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Carts.AddItemToCart;
public sealed record class AddItemToCartCommand(
    Guid CustormerId,
    Guid TicketTypeId,
    decimal Quantity) : ICommand;

internal sealed class AddItemToCartCommandValidation : AbstractValidator<AddItemToCartCommand>
{
    public AddItemToCartCommandValidation()
    {
        RuleFor(c => c.CustormerId).NotEmpty();
        RuleFor(c => c.TicketTypeId).NotEmpty();
        RuleFor(c => c.Quantity).GreaterThan(decimal.Zero);
    }
}
