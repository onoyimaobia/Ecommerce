using System;
using System.Collections.Generic;
using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.SharedLib.Shared.Models;
using MediatR;
namespace Klir.TechChallenge.Web.Mvc.Features.Query
{
    public class ProductsQuery: IQuery<IEnumerable<ProductResource>>
    {
        
    }
}
