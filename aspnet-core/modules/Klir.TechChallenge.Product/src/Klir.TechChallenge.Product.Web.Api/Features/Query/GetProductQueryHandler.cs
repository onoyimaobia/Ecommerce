using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Klir.TechChallenge.Product.Domain.Repository;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using MediatR;
namespace Klir.TechChallenge.Product.Web.Api.Features.Query
{
    public class GetProductQueryHandler : IQueryHandler<GetProductQuery, IEnumerable<ProductResource>>
    {
        private readonly IProductRespository _respository;
        public GetProductQueryHandler(IProductRespository respository)
        {
            _respository = respository;
        }
        public async Task<IEnumerable<ProductResource>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var result = await _respository.GetAllasync();
            var query = from res in result
                        select new ProductResource
                        {
                            Id = res.Id,
                            PromoResource = new PromoResource {
                                ProductId = res.ProductPromo.ProductId,
                                Product = new ProductResource { Price = res.ProductPromo.Product.Price },
                                Id = res.Id,
                                DiscountProductPrice = res.ProductPromo.DiscountProductPrice,
                                DiscountProductQuantity = res.ProductPromo.DiscountProductQuantity,
                                NumberOfFreeProduct = res.ProductPromo.NumberOfFreeProduct,
                                ProductPromoType = res.ProductPromo.ProductPromoType,
                                ProductQuantity = res.ProductPromo.ProductQuantity
                            },
                            Name = res.Name,
                            Price = res.Price,
                            ProductType = res.ProductType.ToString(),
                            Description = res.Description,
                            ImageUrl = res.ImageUrl,
                            CreatedAt = res.CreatedAt
                        };
            return query;
        }
    }
}
