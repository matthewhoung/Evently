using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Events.Application.Events.SearchEvents;
public sealed record class SearchEventsQuery(
    Guid? CategoryId,
    DateTime? StartDate,
    DateTime? EndDate,
    int Page,
    int PageSize) : IQuery<SearchEventsResponse>;
