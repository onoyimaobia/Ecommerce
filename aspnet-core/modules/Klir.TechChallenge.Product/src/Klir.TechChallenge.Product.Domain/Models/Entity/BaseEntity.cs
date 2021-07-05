using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Product.Domain.Models.Entity
{
    /// <summary>
    /// base class for all entity class in product
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// ctor
        /// </summary>
        public BaseEntity()
        {
            IsDeleted = false;
            CreatedAt = DateTime.Now;
            IsActive = false;
        }

        /// <summary>
        /// primary key
        /// </summary>
        [Key]
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
    }
}
