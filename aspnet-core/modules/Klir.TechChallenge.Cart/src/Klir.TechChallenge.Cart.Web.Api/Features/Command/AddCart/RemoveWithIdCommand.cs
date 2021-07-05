using Klir.TechChallenge.SharedLib.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    public class RemoveWithIdCommand: ICommand
    {
        /// <summary>
        /// ctor
        /// </summary>
        public RemoveWithIdCommand(long id)
        {
            CartId = id;
        }
        /// <summary>
        /// cart id
        /// </summary>
        public long CartId { get; set; }
    }
}
