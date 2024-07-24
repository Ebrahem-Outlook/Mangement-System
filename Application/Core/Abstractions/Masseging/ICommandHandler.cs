using Domain.Core.BaseType.Result;
using MediatR;

namespace Application.Core.Abstractions.Masseging;

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : Result
{

}
