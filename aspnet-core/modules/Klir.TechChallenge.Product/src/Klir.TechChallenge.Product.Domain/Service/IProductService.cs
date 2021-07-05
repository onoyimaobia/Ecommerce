using Klir.TechChallenge.Product.Domain.Models.DTO.Payload;
using Klir.TechChallenge.Product.Domain.Models.DTO.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Domain.Service
{
    /// <summary>
    /// product service
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// get all producs 
        /// </summary>
        /// <returns></returns>
        Task<IList<ProductResource>> GetAllasync();
        /// <summary>
        /// add product
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>list of ProductResource</returns>
        Task<long> AddProductAsync(ProductAddPayload payload);
        /// <summary>
        /// update product
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>long</returns>
        Task<long> UpdateProductAsync(ProductUpdatePayload payload);
        /// <summary>
        /// gte product by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>long</returns>
        Task<ProductResource> GetByIdasync(long productId);
        /// <summary>
        /// delete product
        /// </summary>
        /// <param name="productId"></param>
        Task Delete(long productId);
    }
}
