using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Klir.TechChallenge.Cart.Domain.Models.DTO
{
    public class ShoppingCartPayload
    {
        public long ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Count { get; set; }
        public Guid UserId { get; set; }
    }
    public class ShoppingCartUpdatePayload
    {
        public long CartId { get; set; }
        public long ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Count { get; set; }
        public Guid UserId { get; set; }
    }
}
