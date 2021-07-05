using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using MediatR;

namespace Klir.TechChallenge.Product.Web.Api.Features.Command
{
    public class AddPromoCommand: ICommand<StatusResponse>
    {
        public AddPromoCommand(ProductPromoPayload payload)
        {
            Payload = payload;
        }
        public ProductPromoPayload Payload { get;}
    }
}
