using Evently.Common.Domain.Abstractions.Results;
using MediatR;

namespace Evently.Common.Application.Abstractions.Messaging;
public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>;
