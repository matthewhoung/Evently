using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Events.Application.Events.GetEvents;
public sealed class GetEventsQuery : IQuery<IReadOnlyCollection<EventResponse>>;
