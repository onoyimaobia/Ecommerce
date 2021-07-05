
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;

namespace Klir.TechChallenge.Product.Web.Api.Features.Command
{
    public class AddProductCommand: ICommand<StatusResponse>
    {
        public AddProductCommand(ProductAddPayload payload)
        {
            Payload = payload;
        }
        public ProductAddPayload Payload { get; set; }
    }
}
