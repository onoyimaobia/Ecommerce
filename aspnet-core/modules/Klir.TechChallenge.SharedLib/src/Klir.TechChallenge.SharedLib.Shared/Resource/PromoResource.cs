﻿using System;
using Klir.TechChallenge.SharedLib.Shared.Enum;
using Klir.TechChallenge.SharedLib.Shared.Models;

namespace Klir.TechChallenge.SharedLib.Shared.Resource
{
    public class PromoResource
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
        /// product entity
        /// </summary>
        public ProductResource Product { get; set; }
        /// <summary>
        /// promotion type
        /// </summary>
        public ProductPromoType ProductPromoType { get; set; }
        /// <summary>
        /// promotion Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// promotion description
        /// </summary>
        public string PromoDescription { get; set; }
    }
}
