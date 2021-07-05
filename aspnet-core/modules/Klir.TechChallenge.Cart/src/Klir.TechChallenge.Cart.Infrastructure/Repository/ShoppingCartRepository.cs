using Klir.TechChallenge.Cart.Domain.Models.Entity;
using Klir.TechChallenge.Cart.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Cart.Infrastructure.Repository
{
    internal class ShoppingCartRepository : IShoppingCartRepository
    {
        public Task<long> Add(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> AddCart(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> CheckForExist(Guid userId, long productId)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ShoppingCart>> GetAll(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetUserIdCartCount(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> RemoveCart(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Update(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }
    }
}
