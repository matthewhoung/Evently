using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Orders.GetOrders;

public sealed record GetOrdersQuery(Guid CustomerId) : IQuery<IReadOnlyCollection<OrderResponse>>;

public sealed record OrderResponse(
    Guid Id,
    Guid CustomerId,
    OrderStatus Status,
    decimal TotalPrice,
    DateTime CreatedAtUtc);
