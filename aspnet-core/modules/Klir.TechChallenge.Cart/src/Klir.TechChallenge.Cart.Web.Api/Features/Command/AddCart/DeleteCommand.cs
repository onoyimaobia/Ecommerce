using Klir.TechChallenge.SharedLib.Shared;

namespace Klir.TechChallenge.Cart.Web.Api.Features.Command.AddCart
{
    public class DeleteCommand: ICommand
    {
        public DeleteCommand(long id)
        {
            CartId = id;
        }
        /// <summary>
        /// cart Id
        /// </summary>
        public long CartId { get; set; }
    }
}
