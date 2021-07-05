using MediatR;

namespace Klir.TechChallenge.SharedLib.Shared
{

    /// <summary>
    /// query interface
    /// </summary>
    /// <typeparam name="TResult">return value type</typeparam>
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }

}
