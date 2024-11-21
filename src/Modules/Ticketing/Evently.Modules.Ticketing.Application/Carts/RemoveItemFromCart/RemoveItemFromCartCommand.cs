using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Carts.RemoveItemFromCart;
public sealed record RemoveItemFromCartCommand(Guid CustomerId, Guid TicketTypeId) : ICommand;

internal sealed class RemoveItemFromCartCommandValidator : AbstractValidator<RemoveItemFromCartCommand>
{
    public RemoveItemFromCartCommandValidator()
    {
        RuleFor(c => c.CustomerId).NotEmpty();
        RuleFor(c => c.TicketTypeId).NotEmpty();
    }
}
