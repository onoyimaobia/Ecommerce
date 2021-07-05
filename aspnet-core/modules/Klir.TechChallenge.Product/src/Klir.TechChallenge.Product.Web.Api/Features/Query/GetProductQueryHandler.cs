using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Klir.TechChallenge.Product.Domain.Repository;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Enum;
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
                                ProductId = res.ProductPromo != null? res.ProductPromo.ProductId : 0 ,
                                Id = res.ProductPromo !=null? res.ProductPromo.Id :0,
                                DiscountProductPrice = res.ProductPromo != null? res.ProductPromo.DiscountProductPrice : 0,
                                DiscountProductQuantity = res.ProductPromo != null ? res.ProductPromo.DiscountProductQuantity : 0,
                                NumberOfFreeProduct = res.ProductPromo != null ? res.ProductPromo.NumberOfFreeProduct : 0,
                                ProductPromoType = res.ProductPromo!= null ? res.ProductPromo.ProductPromoType: ProductPromoType.DiscountPrice,
                                ProductQuantity = res.ProductPromo != null ? res.ProductPromo.ProductQuantity : 0,
                                PromoDescription = res.ProductPromo != null ? res.ProductPromo.PromoDescription: "defaul"
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
