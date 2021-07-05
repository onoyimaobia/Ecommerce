using Klir.TechChallenge.SharedLib.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Web.Api.Features.Command
{
    public class AddOrderDetailCommandHandler : ICommandHandler<AddOrderDetailCommand>
    {
        public Task<Unit> Handle(AddOrderDetailCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
