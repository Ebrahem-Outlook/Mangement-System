using Domain.Core.BaseType.Result;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Core.Behaviors;

internal sealed class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest
    where TResponse : Result
{

    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Request Started: {@RequestName}, {@RequestDate}", typeof(TRequest).Name, DateTime.UtcNow);

        var response = await next();

        if (response.IsFailure)
        {
            _logger.LogError("Request Failed: {@RequestName}, {RequestDate}", typeof(TRequest).Name, DateTime.UtcNow);
        }

        _logger.LogInformation("Request Started {@RequestName}, {@RequestDate}", typeof(TRequest).Name, DateTime.UtcNow);

        return response;
    }
}
