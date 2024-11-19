using Evently.Common.Application.Abstractions.Messaging;
using FluentValidation;

namespace Evently.Modules.Events.Application.Categories.ArchiveCategory;
public sealed record ArchiveCategoryCommand(Guid CategoryId) : ICommand;

internal sealed class ArchiveCategoryCommandValidator : AbstractValidator<ArchiveCategoryCommand>
{
    public ArchiveCategoryCommandValidator()
    {
        RuleFor(c => c.CategoryId).NotEmpty();
    }
}
