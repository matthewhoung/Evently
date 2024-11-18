using Evently.Modules.Events.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.Categories.UpdateCategory;
public sealed record UpdateCategoryCommand(Guid CategoryId, string Name) : ICommand;

internal sealed class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryCommandValidator()
    {
        RuleFor(c => c.CategoryId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
    }
}
