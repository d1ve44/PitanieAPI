using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class ShoppingListItemService : IShoppingListItemService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ShoppingListItemService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<ShoppingListItem>> GetAll()
        {
            return await _repositoryWrapper.ShoppingListItem.FindAll();
        }

        public async Task<ShoppingListItem> GetById(int id)
        {
            var ShoppingListItem = await _repositoryWrapper.ShoppingListItem
                .FindByCondition(x => x.ShoppingListItemId == id);
            return ShoppingListItem.First();
        }

        public async Task Create(ShoppingListItem model)
        {
            await _repositoryWrapper.ShoppingListItem.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(ShoppingListItem model)
        {
            _repositoryWrapper.ShoppingListItem.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var ShoppingListItem = await _repositoryWrapper.ShoppingListItem
                .FindByCondition(x => x.ShoppingListItemId == id);

            _repositoryWrapper.ShoppingListItem.Delete(ShoppingListItem.First());
            _repositoryWrapper.Save();
        }
    }
}