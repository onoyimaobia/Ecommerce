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
    /// delete cart
    /// </summary>
    public class DeleteCommandHandler : ICommandHandler<DeleteCommand>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Unit> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
