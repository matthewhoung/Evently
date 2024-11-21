﻿using Evently.Common.Application.Abstractions.Messaging;
using Evently.Common.Domain.Abstractions.Results;

namespace Evently.Modules.Ticketing.Application.Carts.GetCart;
internal sealed class GetCartQueryHandler(CartService cartService) : IQueryHandler<GetCartQuery, Cart>
{
    public async Task<Result<Cart>> Handle(GetCartQuery request, CancellationToken cancellationToken)
    {
        return await cartService.GetAsync(request.CustomerId, cancellationToken);
    }
}
