﻿using Evently.Common.Domain.Abstractions.Results;
using MediatR;

namespace Evently.Common.Application.Abstractions.Messaging;
public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : ICommand;

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>;
