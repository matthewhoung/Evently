using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.TicketTypes.CreateTicketType;
public sealed record class CreateTicketTypeCommand(
    Guid EventId,
    string Name,
    decimal Price,
    string Currency,
    decimal Quantity) : ICommand<Guid>;

internal sealed class CreateTicketTypeCommandValidator : AbstractValidator<CreateTicketTypeCommand>
{
    public CreateTicketTypeCommandValidator()
    {
        RuleFor(x => x.EventId).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Price).GreaterThan(decimal.Zero);
        RuleFor(x => x.Currency).NotEmpty();
        RuleFor(x => x.Quantity).GreaterThan(decimal.Zero);
    }
}
