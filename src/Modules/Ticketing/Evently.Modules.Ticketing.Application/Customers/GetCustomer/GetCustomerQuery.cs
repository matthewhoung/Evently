using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Customers.GetCustomer;

public sealed record GetCustomerQuery(Guid CustomerId) : IQuery<CustomerResponse>;
