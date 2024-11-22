using Evently.Common.Domain.Abstractions.Entities;

namespace Evently.Modules.Users.Domain.Users;

public sealed class User : Entity
{
    public Guid Id { get; private set; }
    public string IdentityId { get; private set; }
    public string Email { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private User()
    {
    }

    public static User Create(
        string identityId,
        string email,
        string firstName,
        string lastName)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            IdentityId = identityId,
            Email = email,
            FirstName = firstName,
            LastName = lastName
        };

        user.Raise(new UserRegisteredDomainEvent(user.Id));

        return user;
    }

    public void Update(
        string firstName,
        string lastName)
    {
        if (FirstName == firstName && LastName == lastName)
        {
            return;
        }

        FirstName = firstName;
        LastName = lastName;

        Raise(new UserProfileUpdatedDomainEvent(Id, FirstName, LastName));
    }
}
