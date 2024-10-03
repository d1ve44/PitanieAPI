using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ShoppingListService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<ShoppingList>> GetAll()
        {
            return await _repositoryWrapper.ShoppingList.FindAll();
        }

        public async Task<ShoppingList> GetById(int id)
        {
            var ShoppingList = await _repositoryWrapper.ShoppingList
                .FindByCondition(x => x.ShoppingListId == id);
            return ShoppingList.First();
        }

        public async Task Create(ShoppingList model)
        {
            await _repositoryWrapper.ShoppingList.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(ShoppingList model)
        {
            _repositoryWrapper.ShoppingList.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var ShoppingList = await _repositoryWrapper.ShoppingList
                .FindByCondition(x => x.ShoppingListId == id);

            _repositoryWrapper.ShoppingList.Delete(ShoppingList.First());
            _repositoryWrapper.Save();
        }
    }
}