using Klir.TechChallenge.SharedLib.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    /// <summary>
    /// command add to cart +
    /// </summary>
    public class AddWithIdCommand: ICommand
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="id"></param>
        public AddWithIdCommand(long id)
        {
            CartId = id;
        }
        /// <summary>
        /// cart id
        /// </summary>
        public long CartId { get; set; }
    }
}
