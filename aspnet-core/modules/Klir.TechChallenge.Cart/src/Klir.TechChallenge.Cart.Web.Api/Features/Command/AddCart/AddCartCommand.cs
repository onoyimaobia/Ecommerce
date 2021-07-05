using Klir.TechChallenge.Cart.Domain.Models.DTO;
using Klir.TechChallenge.SharedLib.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    /// <summary>
    /// add cart
    /// </summary>
    public class AddCartCommand: ICommand
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="payload"></param>
        public AddCartCommand(ShoppingCartPayload payload)
        {
            Payload = payload;
        }
        /// <summary>
        /// payload
        /// </summary>
        public ShoppingCartPayload Payload { get; set; }
    }
}
