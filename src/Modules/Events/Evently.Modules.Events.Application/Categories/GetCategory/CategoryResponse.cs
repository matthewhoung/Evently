namespace Evently.Modules.Events.Application.Categories.GetCategory;
public sealed record class CategoryResponse(
    Guid Id,
    string Name,
    bool IsArchived);
