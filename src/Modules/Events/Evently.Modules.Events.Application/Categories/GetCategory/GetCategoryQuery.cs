﻿using Evently.Modules.Events.Application.Abstractions.Messaging;

namespace Evently.Modules.Events.Application.Categories.GetCategory;
public sealed record class GetCategoryQuery(Guid CategoryId) : IQuery<CategoryResponse>;