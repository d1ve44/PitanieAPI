using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class RecipeService : IRecipeService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RecipeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Recipe>> GetAll()
        {
            return await _repositoryWrapper.Recipe.FindAll();
        }

        public async Task<Recipe> GetById(int id)
        {
            var Recipe = await _repositoryWrapper.Recipe
                .FindByCondition(x => x.RecipeId == id);
            return Recipe.First();
        }

        public async Task Create(Recipe model)
        {
            await _repositoryWrapper.Recipe.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Recipe model)
        {
            _repositoryWrapper.Recipe.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var Recipe = await _repositoryWrapper.Recipe
                .FindByCondition(x => x.RecipeId == id);

            _repositoryWrapper.Recipe.Delete(Recipe.First());
            _repositoryWrapper.Save();
        }
    }
}