using Evently.Common.Domain.Abstractions.Entities;

namespace Evently.Modules.Ticketing.Domain.Custormers;

public sealed class Custormer : Entity
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private Custormer() { }

    public static Custormer Create(
        Guid id,
        string email,
        string firstName,
        string lastName)
    {
        return new Custormer
        {
            Id = id,
            Email = email,
            FirstName = firstName,
            LastName = lastName
        };
    }

    public void Update(
        string firstName,
        string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
