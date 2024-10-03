using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class FoodAllergenService : IFoodAllergenService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public FoodAllergenService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<FoodAllergen>> GetAll()
        {
            return await _repositoryWrapper.FoodAllergen.FindAll();
        }

        public async Task<FoodAllergen> GetById(int id)
        {
            var FoodAllergen = await _repositoryWrapper.FoodAllergen
                .FindByCondition(x => x.FoodAllergenId == id);
            return FoodAllergen.First();
        }

        public async Task Create(FoodAllergen model)
        {
            await _repositoryWrapper.FoodAllergen.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(FoodAllergen model)
        {
            _repositoryWrapper.FoodAllergen.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var FoodAllergen = await _repositoryWrapper.FoodAllergen
                .FindByCondition(x => x.FoodAllergenId == id);

            _repositoryWrapper.FoodAllergen.Delete(FoodAllergen.First());
            _repositoryWrapper.Save();
        }
    }
}