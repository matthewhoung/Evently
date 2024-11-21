﻿using Evently.Common.Application.Abstractions.Messaging;
using Evently.Common.Domain.Abstractions.Results;
using Evently.Modules.Ticketing.Domain.Custormers;

namespace Evently.Modules.Ticketing.Application.Carts.ClearCart;
internal sealed class ClearCartCommandHandler(ICustomerRepository customerRepository, CartService cartService)
    : ICommandHandler<ClearCartCommand>
{
    public async Task<Result> Handle(ClearCartCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await customerRepository.GetAsync(request.CustomerId, cancellationToken);

        if (customer is null)
        {
            return Result.Failure(CustomerErrors.NotFound(request.CustomerId));
        }

        await cartService.ClearAsync(customer.Id, cancellationToken);

        return Result.Success();
    }
}
