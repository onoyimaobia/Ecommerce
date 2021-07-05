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
    /// 
    /// </summary>
    public class AddWithIdCommandHandler : ICommandHandler<AddWithIdCommand>
    {
        public Task<Unit> Handle(AddWithIdCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
