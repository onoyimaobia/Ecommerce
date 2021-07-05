

using Klir.TechChallenge.Cart.Domain.Models.DTO;
using Klir.TechChallenge.SharedLib.Shared;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    /// <summary>
    /// update command
    /// </summary>
    public class UpdateCartCommand: ICommand
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="payload"></param>
        public UpdateCartCommand(ShoppingCartUpdatePayload payload)
        {
            Payload = payload;
        }
        /// <summary>
        /// payload
        /// </summary>
        public ShoppingCartUpdatePayload Payload { get; set; }
    }
}
