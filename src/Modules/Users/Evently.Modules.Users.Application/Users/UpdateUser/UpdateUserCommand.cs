using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Users.Application.Users.UpdateUser;
public sealed record class UpdateUserCommand(
    Guid UserId,
    string FirstName,
    string LastName) : ICommand;

internal sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
    }
}
