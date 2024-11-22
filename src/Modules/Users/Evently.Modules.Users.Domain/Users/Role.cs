namespace Evently.Modules.Users.Domain.Users;

public sealed class Role
{
    public string Name { get; private set; }

    private Role()
    {
    }

    private Role(string name)
    {
        Name = name;
    }

    public static readonly Role Administrator = new("Administrator");
    public static readonly Role Member = new("Member");
}
