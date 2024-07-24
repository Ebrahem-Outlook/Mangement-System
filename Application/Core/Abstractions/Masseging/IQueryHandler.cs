using Domain.Core.BaseType.Result;
using MediatR;

namespace Application.Core.Abstractions.Masseging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : Result
{

}
