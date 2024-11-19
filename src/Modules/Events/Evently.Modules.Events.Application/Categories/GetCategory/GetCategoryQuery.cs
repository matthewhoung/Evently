using Evently.Common.Application.Messaging;

namespace Evently.Modules.Events.Application.Categories.GetCategory;
public sealed record class GetCategoryQuery(Guid CategoryId) : IQuery<CategoryResponse>;
