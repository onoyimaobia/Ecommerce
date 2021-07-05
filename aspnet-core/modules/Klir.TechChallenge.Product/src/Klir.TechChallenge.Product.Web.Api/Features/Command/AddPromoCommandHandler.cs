using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Klir.TechChallenge.Product.Domain.Models.Entity;
using Klir.TechChallenge.Product.Domain.Repository;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using MediatR;

namespace Klir.TechChallenge.Product.Web.Api.Features.Command
{
    public class AddPromoCommandHandler : ICommandHandler<AddPromoCommand, StatusResponse>
    {
        private readonly IProductRespository _respository;
        public AddPromoCommandHandler(IProductRespository respository)
        {
            _respository = respository;
        }
        public  async Task<StatusResponse> Handle(AddPromoCommand request, CancellationToken cancellationToken)
        {
            var promo = new ProductPromo
            {
                Price = request.Payload.Price,
                Description = request.Payload.Description,
                Name = request.Payload.Name,
                ImageUrl = request.Payload.ImageUrl,
                ProductType = request.Payload.ProductType,
                CreatedById = request.Payload.CreatedById

            };
            // to do add cancellationtoken very important
            var result = await _respository.AddProductAsync(product);
            return result;
        }
    }
}
