﻿using Evently.Common.Domain.Abstractions.Results;
using MediatR;

namespace Evently.Common.Application.Messaging;
public interface ICommand : IRequest<Result>, IBaseCommand;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand;

public interface IBaseCommand;
