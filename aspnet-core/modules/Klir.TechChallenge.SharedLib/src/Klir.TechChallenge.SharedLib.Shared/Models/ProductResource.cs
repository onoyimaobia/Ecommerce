using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klir.TechChallenge.SharedLib.Shared.Resource;

namespace Klir.TechChallenge.SharedLib.Shared.Models
{
    /// <summary>
    /// product response
    /// </summary>
    public class ProductResource
    {
        /// <summary>
        /// product name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// product description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// product image url
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// product type
        /// </summary>
        public string ProductType { get; set; }
        /// <summary>
        /// product price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Id 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// is product deleted
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// is prodcut active
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Created at
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Update at
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Created By which user
        /// </summary>
        public Guid? CreatedById { get; set; }
        /// <summary>
        /// modified by which user
        /// </summary>
        public Guid? ModifiedById { get; set; }
        public PromoResource PromoResource { get; set; }
    }
}
