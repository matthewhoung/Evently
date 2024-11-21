using Evently.Common.Application.Abstractions.Messaging;
using Evently.Modules.Ticketing.Domain.Orders;

namespace Evently.Modules.Ticketing.Application.Orders.GetOrder;

public sealed record GetOrderQuery(Guid OrderId) : IQuery<OrderResponse>;

public sealed record OrderResponse(
    Guid Id,
    Guid CustomerId,
    OrderStatus Status,
    decimal TotalPrice,
    DateTime CreatedAtUtc)
{
    public List<OrderItemResponse> OrderItems { get; } = [];
}

public sealed record OrderItemResponse(
    Guid OrderItemId,
    Guid OrderId,
    Guid TicketTypeId,
    decimal Quantity,
    decimal UnitPrice,
    decimal Price,
    string Currency);
