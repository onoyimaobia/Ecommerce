using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Domain.Models.DTO
{
    /// <summary>
    /// cart datal payload
    /// </summary>
    public class OrderDetailPayload
    {
        /// <summary>
        /// list of shopping carts
        /// </summary>
        public List<ShoppingCartPayload> Listcarts { get; set; }
        /// <summary>
        /// oder detail
        /// </summary>
        public OrderheaderPayload OrderheaderPayload { get; set; }
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class OrderheaderPayload
    {
        public Guid OrderHeaderId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public DateTime Orderdate { get; set; }
        [Required]
        public decimal OrderTotal { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
    public class ShoppingCartPayload
    {
        public long ShoppingCartId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public long ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
