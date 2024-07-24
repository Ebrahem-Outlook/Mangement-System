using Domain.Core.BaseType.Result;
using MediatR;

namespace Application.Core.Abstractions.Masseging;

public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : Result
{

}
