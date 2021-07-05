using MediatR;

namespace Klir.TechChallenge.SharedLib.Shared
{
    /// <summary>
    /// void returning command handler
    /// </summary>
    /// <typeparam name="TCommand">command type</typeparam>
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : ICommand
    {
    }

    /// <summary>
    /// value returning command handler
    /// </summary>
    /// <typeparam name="TCommand">command type</typeparam>
    /// <typeparam name="TResult">return value type</typeparam>
    public interface ICommandHandler<in TCommand, TResult> :
        IRequestHandler<TCommand, TResult> where TCommand : ICommand<TResult>
    {
    }

}
