﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Resource;
using MediatR;

namespace Klir.TechChallenge.Product.Web.Api.Features.Query
{
    public class GetProductQuery : IQuery<PromoResource>
    {
        /// <summary>
        /// ctor
        /// </summary>
        
        public GetProductQuery()
        {
            
        }
    }
}
