using Klir.TechChallenge.SharedLib.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    public class RemoveWithIdCommandHandler : ICommandHandler<RemoveWithIdCommand>
    {
        /// <summary>
        /// remove from cart
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Unit> Handle(RemoveWithIdCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
