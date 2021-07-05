using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.Product
{
    public class CreateProductCommand: ICommand<StatusResponse>
    {
        public CreateProductCommand(ProductAddPayload payload, IFormFile file)
        {
            Payload = payload;
            File = file;
        }
        public ProductAddPayload Payload { get;}
        public IFormFile File { get; set; }
    }
}
