using Evently.Common.Domain.Abstractions.Results;
using MediatR;
using Microsoft.Extensions.Logging;
using Serilog.Context;

namespace Evently.Common.Application.Behaviors;
#region RequestLoggingPipelineBehavior Explanation
// Logging pipeline act as a middleware to log the request and response of both commands and queries
// Pipline logs the request name and the module name of the request
#endregion
internal sealed class RequestLoggingPipelineBehavior<TRequest, TResponse>(
    ILogger<RequestLoggingPipelineBehavior<TRequest, TResponse>> logger)
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : class
    where TResponse : Result
{
    public async Task<TResponse> Handle(
        TRequest request, 
        RequestHandlerDelegate<TResponse> next, 
        CancellationToken cancellationToken)
    {
        string modelName = GetModuleName(typeof(TRequest).FullName!);
        string requestName = typeof(TRequest).Name;

        using (LogContext.PushProperty("Module", modelName))
        {
            logger.LogInformation("Processing request {RequestName}", requestName);

            TResponse result = await next();

            if (result.IsSuccess)
            {
                logger.LogInformation("Completed request {RequestName}", requestName);
            }
            else
            {
                using (LogContext.PushProperty("Error", result.Error, true))
                {
                    logger.LogError("Completed request {RequestName} with error", requestName);
                }
            }

            return result;
        }
    }
    #region GetModuleName Explanation
    // because of our naming convention, for example, Evently.Modules.Events.Application
    // we can extract the module name by splitting the request name by '.' and getting the third element
    // which is the module name = "Events"
    // there for we can use this method to get the module name
    #endregion
    private static string GetModuleName(string requestName) => requestName.Split('.')[2];
}
