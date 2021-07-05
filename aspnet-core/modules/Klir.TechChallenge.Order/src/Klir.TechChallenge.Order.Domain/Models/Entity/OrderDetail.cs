using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Order.Domain.Models.Entity
{
    public class OrderDetail:BaseEntity
    {
        [Required]
        [ForeignKey("OrderHeader")]
        public Guid OrderHeaderId { get; set; }
        public virtual OrderHeader OrderHeader { get; set; }
        [Required]
        public long ProductId { get; set; }
        [Required]
        public int Count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public long? PromotionId { get; set; }
    }
}
