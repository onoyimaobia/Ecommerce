using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.Product
{
    public class CreatePromoCommandHandler : ICommandHandler<CreatePromoCommand, StatusResponse>
    {
        private const string baseUrl = "http://localhost:32152/";
        private readonly ILogger<CreatePromoCommandHandler> _logger;
        public CreatePromoCommandHandler(ILogger<CreatePromoCommandHandler> logger)
        {
            _logger = logger;
        }
        public async Task<StatusResponse> Handle(CreatePromoCommand request, CancellationToken cancellationToken)
        {
            string _requestEndPoint = "api/products/promo";
            _logger.LogInformation($"Payload built for request {request}");
            _logger.LogInformation($"Request Url {baseUrl + _requestEndPoint}");
            HttpResponseMessage response = null;
            StatusResponse statusResponse = null;
            try
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(request.Payload), Encoding.UTF8, "application/json");

                    using (response = await httpClient.PostAsync(baseUrl + _requestEndPoint, content))
                    {
                        statusResponse = await HandleResponseCall(response);
                    }
                }
                return statusResponse;
            }

            catch (Exception e)
            {
                // Log Error
                _logger.LogCritical($"The Http Request to {baseUrl + _requestEndPoint} failed with the following error: {e}");
                return new StatusResponse { Status = false, Message = "service error" };
            }
        }
        private async Task<StatusResponse> HandleResponseCall(HttpResponseMessage responseMessage)
        {
            var resultStr = await responseMessage.Content.ReadAsStringAsync();
            var endPoint = responseMessage.RequestMessage.RequestUri.ToString();
            var response = new StatusResponse { };

            if (!responseMessage.IsSuccessStatusCode || string.IsNullOrEmpty(resultStr))
            {
                _logger.LogCritical($"The Http Request to {responseMessage.RequestMessage.RequestUri.ToString()} is not successful");
                response = new StatusResponse { Status = false, Message = "error occured on the external server" };
                return response;
            }
            _logger.LogInformation($"Response raw json: {resultStr} with uri {endPoint}");
            response = JsonConvert.DeserializeObject<StatusResponse>(resultStr);
            return response;
        }
    }
}
