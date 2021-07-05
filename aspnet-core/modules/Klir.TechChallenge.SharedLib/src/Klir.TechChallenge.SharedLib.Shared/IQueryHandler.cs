

using MediatR;

namespace Klir.TechChallenge.SharedLib.Shared
{
    /// <summary>
    /// query handler
    /// </summary>
    /// <typeparam name="TQuery">query type</typeparam>
    /// <typeparam name="TResult">result value type</typeparam>
    public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
    }

}
