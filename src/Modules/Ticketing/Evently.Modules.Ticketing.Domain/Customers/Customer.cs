﻿using Evently.Common.Domain.Abstractions.Entities;

namespace Evently.Modules.Ticketing.Domain.Custormers;

public sealed class Customer : Entity
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private Customer() { }

    public static Customer Create(
        Guid id,
        string email,
        string firstName,
        string lastName)
    {
        return new Customer
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
