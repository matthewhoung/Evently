﻿using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Events.CancelEvent;

public sealed record CancelEventCommand(Guid EventId) : ICommand;
