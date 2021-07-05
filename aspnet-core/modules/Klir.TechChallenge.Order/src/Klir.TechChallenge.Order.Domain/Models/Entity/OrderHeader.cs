using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Domain.Models.Entity
{
    /// <summary>
    ///  order header
    /// </summary>
    public class OrderHeader: BaseEntity
    {
        
        /// <summary>
        /// total amount of order
        /// </summary>
        [Required]
        public decimal OrderTotal { get; set; }
        /// <summary>
        /// oder status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// order comment
        /// </summary>
        public string Comment { get; set; }

    }
}
