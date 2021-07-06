
using Klir.TechChallenge.Product.Domain.Repository;
using Klir.TechChallenge.Product.Web.Api.Features.Command;
using Klir.TechChallenge.SharedLib.Shared.Enum;
using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using Moq;
using Moq.AutoMock;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Klir.TechChallenge.Cart.Tests
{
    public class AddProductCommandHandlerTest
    {
        private readonly Mock<IProductRespository> _repository;
        private readonly AddProductCommandHandler _handler;

        public AddProductCommandHandlerTest()
        {
            var autoMocker = new AutoMocker();
            _repository =  autoMocker.GetMock<IProductRespository>();
            _handler = autoMocker.CreateInstance<AddProductCommandHandler>();
        }

        [Fact]
        public async Task Handle_ShouldReturnStatus_WhenOk()
        {
            // Arrange
            var product = new ProductAddPayload
            {
                Price = 100.99M,
                Description = "testing this",
                Name = "Klir diverter",
                ImageUrl = "/productImages/1234567.png",
                ProductType = ProductType.FullAutomatic,
                CreatedById = Guid.NewGuid()
            };
            var testCommand = new AddProductCommand(product);
            var testResult = new StatusResponse
            {
                Status = true
            };
            _repository.Setup(r => r.AddProductAsync(It.IsAny<Klir.TechChallenge.Product.Domain.Models.Entity.Product>()))
                .ReturnsAsync(testResult);

            // Act
            var result = await _handler.Handle(testCommand, default);

            // Arrange
            Assert.Equal(testResult.Status, result.Status);
        }

    }
}
