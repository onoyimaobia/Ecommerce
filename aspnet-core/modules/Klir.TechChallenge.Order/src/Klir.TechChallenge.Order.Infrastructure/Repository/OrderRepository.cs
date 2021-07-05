using Klir.TechChallenge.Order.Domain.Models.DTO;
using Klir.TechChallenge.Order.Domain.Models.Entity;
using Klir.TechChallenge.Order.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Infrastructure.Repository
{
    /// <summary>
    /// order detairepository
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// add order detail
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        public Task<long> AddAsync(OrderDetail payload)
        {
            throw new NotImplementedException();
        }
    }
}
