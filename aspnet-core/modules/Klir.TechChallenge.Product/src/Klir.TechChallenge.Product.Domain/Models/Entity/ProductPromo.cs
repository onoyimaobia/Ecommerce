
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.SharedLib.Shared.Enum;

namespace Klir.TechChallenge.Product.Domain.Models.Entity
{
    /// <summary>
    /// product promotion
    /// </summary>
    public class ProductPromo: BaseEntity
    {
        /// <summary>
        /// this is the number of product quantity to apply promo  on
        /// eg. buy 1 get 1 free
        /// </summary>
        public int ProductQuantity { get; set; }
        /// <summary>
        /// this is number of free product tied to 
        /// </summary>
        public int NumberOfFreeProduct { get; set; }
        /// <summary>
        /// discount product qauntity
        /// eg 3 product per 10 dolar
        /// </summary>
        public int DiscountProductQuantity { get; set; }
        /// <summary>
        /// discount product price
        /// eg 10 dolar for 3 product
        /// </summary>
        public double DiscountProductPrice { get; set; }
        /// <summary>
        /// mapping promoid
        /// </summary>
        [ForeignKey("Product")]
        public long ProductId { get; set; }
        /// <summary>
        /// product entity
        /// </summary>
        public virtual Product Product { get; set; }
        /// <summary>
        /// promotion type
        /// </summary>
        public ProductPromoType ProductPromoType { get; set; }
    }
}
