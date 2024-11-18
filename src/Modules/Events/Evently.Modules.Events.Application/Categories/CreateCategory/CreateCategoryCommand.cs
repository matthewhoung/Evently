using Evently.Modules.Events.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.Categories.CreateCategory;
public sealed record class CreateCategoryCommand(string Name) : ICommand<Guid>;

internal sealed class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
    }
}
