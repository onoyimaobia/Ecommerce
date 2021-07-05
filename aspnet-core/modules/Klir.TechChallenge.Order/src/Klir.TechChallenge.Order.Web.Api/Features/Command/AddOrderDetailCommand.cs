using Klir.TechChallenge.Order.Domain.Models.DTO;
using Klir.TechChallenge.SharedLib.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Web.Api.Features.Command
{
    public class AddOrderDetailCommand: ICommand
    {
        public AddOrderDetailCommand(OrderDetailPayload payload)
        {
            Payload = payload;
        }
        public OrderDetailPayload Payload { get; set; }
    }
}
