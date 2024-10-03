using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class MealPlanService : IMealPlanService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MealPlanService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<MealPlan>> GetAll()
        {
            return await _repositoryWrapper.MealPlan.FindAll();
        }

        public async Task<MealPlan> GetById(int id)
        {
            var MealPlan = await _repositoryWrapper.MealPlan
                .FindByCondition(x => x.MealPlanId == id);
            return MealPlan.First();
        }

        public async Task Create(MealPlan model)
        {
            await _repositoryWrapper.MealPlan.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(MealPlan model)
        {
            _repositoryWrapper.MealPlan.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var MealPlan = await _repositoryWrapper.MealPlan
                .FindByCondition(x => x.MealPlanId == id);

            _repositoryWrapper.MealPlan.Delete(MealPlan.First());
            _repositoryWrapper.Save();
        }
    }
}