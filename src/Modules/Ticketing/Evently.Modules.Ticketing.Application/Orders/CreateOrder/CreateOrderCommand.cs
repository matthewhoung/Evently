using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Orders.CreateOrder;

public sealed record CreateOrderCommand(Guid CustomerId) : ICommand;

internal sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(c => c.CustomerId).NotEmpty();
    }
}
