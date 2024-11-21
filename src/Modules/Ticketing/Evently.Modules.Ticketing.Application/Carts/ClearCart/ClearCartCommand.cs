using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Carts.ClearCart;
public sealed record class ClearCartCommand(Guid CustomerId) : ICommand;

internal sealed class ClearCartCommandValidator : AbstractValidator<ClearCartCommand>
{
    public ClearCartCommandValidator()
    {
        RuleFor(c => c.CustomerId).NotEmpty();
    }
}
