namespace Evently.Modules.Ticketing.Domain.Custormers;
public interface ICustomerRepository
{
    Task<Customer?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Customer customer);
}
