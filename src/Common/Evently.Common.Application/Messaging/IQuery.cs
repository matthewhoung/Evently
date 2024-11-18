using Evently.Common.Domain.Abstractions.Results;
using MediatR;

namespace Evently.Common.Application.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>>;
