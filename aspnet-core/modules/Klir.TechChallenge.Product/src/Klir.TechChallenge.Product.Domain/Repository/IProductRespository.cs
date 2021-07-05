
using Klir.TechChallenge.Product.Domain.Models.DTO.Payload;
using Klir.TechChallenge.Product.Domain.Models.DTO.Resource;
using Klir.TechChallenge.Product.Domain.Models.Entity;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Domain.Repository
{
    /// <summary>
    /// product repositry interface
    /// </summary>
    public interface IProductRespository
    {
        /// <summary>
        /// get all producs 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Models.Entity.Product>> GetAllasync();
        /// <summary>
        /// get all producs 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductPromo>> GetAllPromoasync();
        /// <summary>
        /// add product
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>list of ProductResource</returns>
        Task<StatusResponse> AddProductAsync(Models.Entity.Product payload);
        /// <summary>
        /// update product
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>long</returns>
        Task<long> UpdateProductAsync(Models.Entity.Product payload);
        /// <summary>
        /// gte product by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>long</returns>
        Task<Models.Entity.Product> GetByIdasync(long productId);
        /// <summary>
        /// delete product
        /// </summary>
        /// <param name="product"></param>
        Task Delete(Models.Entity.Product product);
        /// <summary>
        /// add product
        /// </summary>
        /// <param name="payload"></param>
        /// <returns>list of ProductResource</returns>
        Task<StatusResponse> AddPromoAsync(ProductPromo payload);

    }
}
