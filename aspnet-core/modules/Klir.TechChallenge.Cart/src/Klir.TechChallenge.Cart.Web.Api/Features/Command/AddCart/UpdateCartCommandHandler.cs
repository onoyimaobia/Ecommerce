using Klir.TechChallenge.Cart.Domain.Repository;
using Klir.TechChallenge.SharedLib.Shared;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    /// <summary>
    /// update cart handler
    /// </summary>
    public class UpdateCartCommandHandler : ICommandHandler<UpdateCartCommand>
    {
        private readonly IShoppingCartRepository _cartRepository;

        public UpdateCartCommandHandler(IShoppingCartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        /// <summary>
        /// update cart
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Unit> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
