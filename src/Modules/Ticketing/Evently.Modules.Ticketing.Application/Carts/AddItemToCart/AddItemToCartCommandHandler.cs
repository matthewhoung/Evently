using Evently.Common.Application.Abstractions.Messaging;
using Evently.Common.Domain.Abstractions.Results;
using Evently.Modules.Ticketing.Domain.Custormers;

namespace Evently.Modules.Ticketing.Application.Carts.AddItemToCart;
internal sealed class AddItemToCartCommandHandler(
    ICustomerRepository customerRepository,
    CartService cartService)
    : ICommandHandler<AddItemToCartCommand>
{
    public async Task<Result> Handle(AddItemToCartCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await customerRepository.GetAsync(request.CustomerId, cancellationToken);

        if (customer is null)
        {
            return Result.Failure(CustomerErrors.NotFound(request.CustomerId));
        }


    }
}
