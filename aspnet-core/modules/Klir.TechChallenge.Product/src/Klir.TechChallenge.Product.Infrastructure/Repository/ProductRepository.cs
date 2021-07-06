
using Klir.TechChallenge.Product.Domain.Models.Entity;
using Klir.TechChallenge.Product.Domain.Repository;
using Klir.TechChallenge.Product.Infrastructure.DataContext;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Infrastructure.Repository
{
    public class ProductRepository : IProductRespository
    {
        private readonly ProductDbContext _context;
        private readonly ILogger<ProductRepository> _logger;
        public ProductRepository(ProductDbContext context, ILogger<ProductRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<StatusResponse> AddProductAsync(Domain.Models.Entity.Product payload)
        {
            _context.Add(payload);
            if (!await _context.TrySaveChangesAsync(_logger))
                return new StatusResponse { Status = false, Message = "unable to save to db" };
            return new StatusResponse { Status = true, Message = "success" };
        }

        public async Task<StatusResponse> AddPromoAsync(ProductPromo payload)
        {
            _context.Add(payload);
            if (!await _context.TrySaveChangesAsync(_logger))
                return new StatusResponse { Status = false, Message = "unable to save to db" };
            return new StatusResponse { Status = true, Message = "success" };
        }

        public Task Delete(Domain.Models.Entity.Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Domain.Models.Entity.Product>> GetAllasync()
        {
            return  await _context.Products.Include(m => m.ProductPromo).OrderBy(i => i.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<ProductPromo>> GetAllPromoasync()
        {
            return await _context.ProductPromo.Include(m => m.Product).OrderBy(i => i.CreatedAt).ToListAsync();
        }

        public Task<Domain.Models.Entity.Product> GetByIdasync(long productId)
        {
            throw new NotImplementedException();
        }

        public Task<long> UpdateProductAsync(Domain.Models.Entity.Product payload)
        {
            throw new NotImplementedException();
        }
    }
}
