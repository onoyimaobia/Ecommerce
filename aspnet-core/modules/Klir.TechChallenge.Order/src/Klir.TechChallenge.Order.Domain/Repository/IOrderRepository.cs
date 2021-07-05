using Klir.TechChallenge.Order.Domain.Models.DTO;
using Klir.TechChallenge.Order.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Domain.Repository
{
    /// <summary>
    /// order repository
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// add order detail
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        Task<long> AddAsync(OrderDetail payload);
    }
}
