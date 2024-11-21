﻿using Evently.Common.Application.Abstractions.Messaging;
using Evently.Common.Domain.Abstractions.Results;
using Evently.Modules.Ticketing.Domain.Custormers;
using Evently.Modules.Ticketing.Domain.TicketTypes;

namespace Evently.Modules.Ticketing.Application.Carts.RemoveItemFromCart;
internal sealed class RemoveItemFromCartCommandHandler(
    ICustomerRepository customerRepository,
    ITicketTypeRepository ticketTypeRepository,
    CartService cartService)
    : ICommandHandler<RemoveItemFromCartCommand>
{
    public async Task<Result> Handle(RemoveItemFromCartCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await customerRepository.GetAsync(request.CustomerId, cancellationToken);

        if (customer is null)
        {
            return Result.Failure(CustomerErrors.NotFound(request.CustomerId));
        }

        TicketType? ticketType = await ticketTypeRepository.GetAsync(request.TicketTypeId, cancellationToken);

        if (ticketType is null)
        {
            return Result.Failure(TicketTypeErrors.NotFound(request.TicketTypeId));
        }

        await cartService.RemoveItemAsync(customer.Id, ticketType.Id, cancellationToken);

        return Result.Success();
    }
}
