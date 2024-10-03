using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class FoodItemCategoryService : IFoodItemCategoryService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public FoodItemCategoryService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<FoodItemCategory>> GetAll()
        {
            return await _repositoryWrapper.FoodItemCategory.FindAll();
        }

        public async Task<FoodItemCategory> GetById(int id)
        {
            var FoodItemCategory = await _repositoryWrapper.FoodItemCategory
                .FindByCondition(x => x.FoodItemCategoryId == id);
            return FoodItemCategory.First();
        }

        public async Task Create(FoodItemCategory model)
        {
            await _repositoryWrapper.FoodItemCategory.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(FoodItemCategory model)
        {
            _repositoryWrapper.FoodItemCategory.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var FoodItemCategory = await _repositoryWrapper.FoodItemCategory
                .FindByCondition(x => x.FoodItemCategoryId == id);

            _repositoryWrapper.FoodItemCategory.Delete(FoodItemCategory.First());
            _repositoryWrapper.Save();
        }
    }
}