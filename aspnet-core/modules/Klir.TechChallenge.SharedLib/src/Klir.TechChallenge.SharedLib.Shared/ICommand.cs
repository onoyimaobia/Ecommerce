using MediatR;

namespace Klir.TechChallenge.SharedLib.Shared
{
    /// <summary>
    /// command with a return value
    /// </summary>
    /// <typeparam name="TResult">type of return value</typeparam>
    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }

    /// <summary>
    /// void returning command
    /// </summary>
    public interface ICommand : IRequest<Unit>
    {
    }

}
