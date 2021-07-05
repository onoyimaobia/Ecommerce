using Klir.TechChallenge.Product.Domain.Models.DTO.Payload;
using Klir.TechChallenge.Product.Domain.Models.DTO.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Domain.Service
{
    internal class ProductService : IProductService
    {
        public Task<long> AddProductAsync(ProductAddPayload payload)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ProductResource>> GetAllasync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductResource> GetByIdasync(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<long> UpdateProductAsync(ProductUpdatePayload payload)
        {
            throw new NotImplementedException();
        }
    }
}
