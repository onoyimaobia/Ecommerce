using Klir.TechChallenge.Order.Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Domain.Service
{
    /// <summary>
    /// order service
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// add order detail
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        Task<long> AddAsync(OrderDetailPayload payload);
    }
}
