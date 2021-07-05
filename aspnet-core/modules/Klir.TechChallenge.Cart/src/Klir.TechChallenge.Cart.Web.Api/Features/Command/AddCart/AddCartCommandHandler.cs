using Klir.TechChallenge.Cart.Domain.Repository;
using Klir.TechChallenge.SharedLib.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    /// <summary>
    /// create cart
    /// </summary>
    public class AddCartCommandHandler : ICommandHandler<AddCartCommand>
    {
        private readonly IShoppingCartRepository _cartRepository;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="cartRepository"></param>
        public AddCartCommandHandler(IShoppingCartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        /// <summary>
        /// handle shopping cart create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Unit> Handle(AddCartCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
