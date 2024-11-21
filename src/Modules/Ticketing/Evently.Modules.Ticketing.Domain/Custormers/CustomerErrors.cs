using Evently.Common.Domain.Abstractions.Errors;

namespace Evently.Modules.Ticketing.Domain.Custormers;
public static class CustomerErrors
{
    public static Error NotFound(Guid customerId) => Error.NotFound(
        "Customers.NotFound", 
        $"The customer with the identifier {customerId} was not found");
}
