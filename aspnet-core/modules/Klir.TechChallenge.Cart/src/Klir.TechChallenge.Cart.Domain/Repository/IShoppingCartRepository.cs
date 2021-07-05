using Klir.TechChallenge.Cart.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Domain.Repository
{

    /// <summary>
    /// shopping cart repo
    /// </summary>
    public interface IShoppingCartRepository
    {
        /// <summary>
        /// add to db
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        Task<long> Add(ShoppingCart shoppingCart);
        /// <summary>
        /// delete cart
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        Task Delete(ShoppingCart shoppingCart);
        /// <summary>
        /// get cart by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ShoppingCart> GetById(long id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ShoppingCart> AddCart(long id);
        /// <summary>
        /// remove cart
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ShoppingCart> RemoveCart(long id);
        /// <summary>
        /// get count by a particular user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> GetUserIdCartCount(Guid id);
        /// <summary>
        /// get all cart for a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IList<ShoppingCart>> GetAll(Guid userId);
        /// <summary>
        /// update cart
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        Task<long> Update(ShoppingCart shoppingCart);
        /// <summary>
        /// Check For Existence
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<ShoppingCart> CheckForExist(Guid userId, long productId);
    }
}
