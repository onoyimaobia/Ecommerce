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
    public class GetPromoQueryHandler : IQueryHandler<GetPromoQuery, IEnumerable<PromoResource>>
    {
        private readonly IProductRespository _respository;
        public GetPromoQueryHandler(IProductRespository respository)
        {
            _respository = respository;
        }
        public async Task<IEnumerable<PromoResource>> Handle(GetPromoQuery request, CancellationToken cancellationToken)
        {
            var result = await _respository.GetAllPromoasync();
            var query = from res in result
                        select new PromoResource
                        {
                            ProductId = res.ProductId,
                            Product = new ProductResource { Price = res.Product.Price },
                            Id = res.Id,
                            DiscountProductPrice = res.DiscountProductPrice,
                            DiscountProductQuantity = res.DiscountProductQuantity,
                            NumberOfFreeProduct = res.NumberOfFreeProduct,
                            ProductPromoType = res.ProductPromoType,
                            ProductQuantity = res.ProductQuantity
                        };
            return query;
        }
    }
}
