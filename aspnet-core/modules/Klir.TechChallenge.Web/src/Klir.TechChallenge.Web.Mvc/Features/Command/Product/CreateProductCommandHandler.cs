using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Extensions;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using MediatR;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.Product
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, StatusResponse>
    {
        // Todo Log
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<CreateProductCommandHandler> _logger;
        private readonly IWebHostEnvironment _environment;

        private const string baseUrl = "http://localhost:32152/";
        public CreateProductCommandHandler(IHttpClientFactory clientFactory, 
            ILogger<CreateProductCommandHandler> logger, IWebHostEnvironment environment)
        {
            this._clientFactory = clientFactory;
            this._logger = logger;
            this._environment = environment;

        }
        public async Task<StatusResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var imageUrls = SaveImage(request.File);
            request.Payload.ImageUrl = imageUrls;
            string _requestEndPoint = "api/products";
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(baseUrl);
            var payload = JsonConvert.SerializeObject(request.Payload);
            _logger.LogInformation($"Payload built for request {payload}");
            _logger.LogInformation($"Request Headers {client.DefaultRequestHeaders}");
            _logger.LogInformation($"Request Url {client.BaseAddress + _requestEndPoint}");
            HttpResponseMessage result = null;
            try
            {
                result = await client.PostAsJsonStringAsync(_requestEndPoint, payload);
                //Log Info
                _logger.LogInformation($"The Response returned {result}");
                //Return ServiceRepsore
                return await HandleResponseCall(result);
            }
            catch (Exception e)
            {
                // Log Error
                _logger.LogCritical($"The Http Request to {client.BaseAddress + _requestEndPoint} failed with the following error: {e}");
                return new StatusResponse { Status = false, Message = "service error" };
            }
        }
        private string BuildPayload(CreateProductCommand request, string imageUrl)
        {
            using var stream = new MemoryStream();
            const string FloatingAmount = "F";

            using (var writer = new Utf8JsonWriter(stream))
            {
                writer.WriteStartObject();
                writer.WriteString("ProductType", request.Payload.ProductType.ToString());
                writer.WriteString("Price", request.Payload.Price.ToString(FloatingAmount, CultureInfo.InvariantCulture));
                writer.WriteString("ImageUrl", imageUrl);
                writer.WriteString("Name", request.Payload.Name);
                writer.WriteString("Description", request.Payload.Description);
                //writer.WriteString("CreatedById", request.Payload.CreatedById.Value);
                writer.WriteEndObject();

            }
            return Encoding.UTF8.GetString(stream.ToArray());
        }
        private async Task<StatusResponse> HandleResponseCall(HttpResponseMessage responseMessage)
        {
            var resultStr = await responseMessage.Content.ReadAsStringAsync();
            var endPoint = responseMessage.RequestMessage.RequestUri.ToString();
            var response = new StatusResponse { };

            if (!responseMessage.IsSuccessStatusCode || string.IsNullOrEmpty(resultStr))
            {
                _logger.LogCritical($"The Http Request to {responseMessage.RequestMessage.RequestUri.ToString()} is not successful");
                response = new StatusResponse {Status = false, Message = "error occured on the external server"};
               return response;
            }
            _logger.LogInformation($"Response raw json: {resultStr} with uri {endPoint}");
            response = JsonConvert.DeserializeObject<StatusResponse>(resultStr);
            return response;
        }
        private string SaveImage(IFormFile file)
        {
            FileInfo fi = new FileInfo(file.FileName);
            var newFilename = String.Format("{0:d}",(DateTime.Now.Ticks / 10) % 100000000) + fi.Extension;
            var webPath = _environment.WebRootPath;
            var path = Path.Combine("", webPath + @"\ProductImages\" + newFilename);

            // IMPORTANT: The pathToSave variable will be save on the column in the database
            var pathToSave = @"/ProductImages/" + newFilename;

            // This stream the physical file to the allocate wwwroot/ImageFiles folder
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }
             return pathToSave;
        }
    }
}
