using Domain.Core.BaseType.Result;
using MediatR;

namespace Application.Core.Abstractions.Masseging;

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : Result
{

}
