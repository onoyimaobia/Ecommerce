using Klir.TechChallenge.Product.Web.Api.Features.Command;
using Klir.TechChallenge.Product.Web.Api.Features.Query;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Klir.TechChallenge.Product.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<PromoResource>> GetAllAsync()
        {
            return await _mediator.Send(new GetPromoQuery());
        }
        [HttpGet]
        [Route("promo")]
        public async Task<IEnumerable<ProductResource>> GetPromosAsync()
        {
            return await _mediator.Send(new GetProductQuery());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<StatusResponse>  Post([FromBody] ProductAddPayload payload)
        {
            return await _mediator.Send(new AddProductCommand(payload));
        }
        // POST api/<ProductsController>
        [HttpPost]
        [Route("promo")]
        public async Task<StatusResponse> PostPromo([FromBody] ProductPromoPayload payload)
        {
            return await _mediator.Send(new AddPromoCommand(payload));
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
