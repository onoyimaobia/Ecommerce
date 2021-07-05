using Klir.TechChallenge.Product.Domain.Repository;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Web.Api.Features.Command
{
    public class AddProductCommandHandler : ICommandHandler<AddProductCommand, StatusResponse>
    {
        private readonly IProductRespository _respository;
        public AddProductCommandHandler(IProductRespository respository)
        {
            _respository = respository;
        }
        public async Task<StatusResponse> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Klir.TechChallenge.Product.Domain.Models.Entity.Product
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
