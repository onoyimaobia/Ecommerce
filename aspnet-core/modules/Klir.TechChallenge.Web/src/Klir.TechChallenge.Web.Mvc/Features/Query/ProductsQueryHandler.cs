using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Klir.TechChallenge.Web.Mvc.Features.Query
{
    public class ProductsQueryHandler : IQueryHandler<ProductsQuery, IEnumerable<ProductResource>>
    {

        private const string baseUrl = "http://localhost:32152/";
        private readonly ILogger _logger;
        public ProductsQueryHandler(ILogger logger)
        {
            _logger = logger;
        }
        public async Task<IEnumerable<ProductResource>> Handle(ProductsQuery request, CancellationToken cancellationToken)
        {
        
            string _requestEndPoint = "api/products";
            _logger.LogInformation($"Payload built for request {request}");
            _logger.LogInformation($"Request Url {baseUrl + _requestEndPoint}");
            HttpResponseMessage response = null;
            try
            {
                List<ProductResource> products = new List<ProductResource>();
                using (var httpClient = new HttpClient())
                {
                    using (response = await httpClient.GetAsync(baseUrl+_requestEndPoint))
                    {
                        products = await HandleResponseCall(response);
                    }
                }
                return products;
            }

            catch (Exception e)
            {
                // Log Error
                _logger.LogCritical($"The Http Request to {baseUrl + _requestEndPoint} failed with the following error: {e}");
                return null;
            }
        }
        private async Task<List<ProductResource>> HandleResponseCall(HttpResponseMessage responseMessage)
        {
            var resultStr = await responseMessage.Content.ReadAsStringAsync();
            var endPoint = responseMessage.RequestMessage.RequestUri.ToString();
            var response = new List<ProductResource> { };

            if (!responseMessage.IsSuccessStatusCode || string.IsNullOrEmpty(resultStr))
            {
                _logger.LogCritical($"The Http Request to {responseMessage.RequestMessage.RequestUri.ToString()} is not successful");
                
                return response;
            }
            _logger.LogInformation($"Response raw json: {resultStr} with uri {endPoint}");
            response = JsonConvert.DeserializeObject<List<ProductResource>>(resultStr);
            return response;
        }
    }
    
}
