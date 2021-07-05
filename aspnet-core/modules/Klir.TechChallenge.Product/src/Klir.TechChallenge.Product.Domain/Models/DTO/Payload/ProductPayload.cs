using Klir.TechChallenge.Product.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Domain.Models.DTO.Payload
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
        [StringLength(100, ErrorMessage =" description should be more than 10 charactes", MinimumLength = 10)]
        public string Description { get; set; }

        /// <summary>
        /// product image url
        /// </summary>
        [Required]
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
        public double Price { get; set; }
    }

    /// <summary>
    /// update product payload
    /// </summary>
    public class ProductUpdatePayload: ProductPayload
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
}
