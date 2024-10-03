﻿using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class FoodItemService : IFoodItemService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public FoodItemService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<FoodItem>> GetAll()
        {
            return await _repositoryWrapper.FoodItem.FindAll();
        }

        public async Task<FoodItem> GetById(int id)
        {
            var FoodItem = await _repositoryWrapper.FoodItem
                .FindByCondition(x => x.FoodItemId == id);
            return FoodItem.First();
        }

        public async Task Create(FoodItem model)
        {
            await _repositoryWrapper.FoodItem.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(FoodItem model)
        {
            _repositoryWrapper.FoodItem.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var FoodItem = await _repositoryWrapper.FoodItem
                .FindByCondition(x => x.FoodItemId == id);

            _repositoryWrapper.FoodItem.Delete(FoodItem.First());
            _repositoryWrapper.Save();
        }
    }
}