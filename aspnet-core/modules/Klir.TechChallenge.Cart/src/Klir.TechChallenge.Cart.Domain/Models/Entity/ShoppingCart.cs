using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Domain.Models.Entity
{
    /// <summary>
    /// shopping cart table
    /// </summary>
    public class ShoppingCart: BaseEntity
    {
      /// <summary>
      /// product id
      /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// number of items
        /// </summary>

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Count { get; set; }
    }
}
