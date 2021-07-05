
using Klir.TechChallenge.SharedLib.Shared.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Domain.Models.Entity
{
    /// <summary>
    ///  product class
    /// </summary>
    public class Product: BaseEntity
    {
        /// <summary>
        /// product name
        /// </summary>
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
        public decimal Price { get; set; }
       
        /// <summary>
        /// product promotion
        /// </summary>
        public virtual ProductPromo ProductPromo { get; set; }
    }
}
