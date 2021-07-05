using Klir.TechChallenge.Order.Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Domain.Service
{
    internal class OrderService : IOrderService
    {
        public Task<long> AddAsync(OrderDetailPayload payload)
        {
            throw new NotImplementedException();
        }
    }
}
