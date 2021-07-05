using Klir.TechChallenge.SharedLib.Shared.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.SharedLib.Shared.Models
{ 
       /// <summary>
      ///  product payload
      /// </summary>
    public class ProductPayload
    {
        /// <summary>
        /// product name
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// product description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// product image url
        /// </summary>
      
        public string ImageUrl { get; set; }
        /// <summary>
        /// product type
        /// </summary>
        [Required]
        public ProductType ProductType { get; set; }
        /// <summary>
        /// product price
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Price { get; set; }
    }

    /// <summary>
    /// update product payload
    /// </summary>
    public class ProductUpdatePayload : ProductPayload
    {
        /// <summary>
        /// product Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// modified by which user
        /// </summary>
        public Guid? ModifiedById { get; set; }
    }
    /// <summary>
    /// add product payload
    /// </summary>
    public class ProductAddPayload : ProductPayload
    {
        /// <summary>
        /// Created By which user
        /// </summary>
        public Guid? CreatedById { get; set; }
    }
    public class ProductPromoPayload
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
       
        public long ProductId { get; set; }
        
        /// <summary>
        /// promotion type
        /// </summary>
        public ProductPromoType ProductPromoType { get; set; }
    }
}
