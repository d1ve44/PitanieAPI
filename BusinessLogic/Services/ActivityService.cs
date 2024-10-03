﻿using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class ActivityService : IActivityService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ActivityService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Activity>> GetAll()
        {
            return await _repositoryWrapper.Activity.FindAll();
        }

        public async Task<Activity> GetById(int id)
        {
            var Activity = await _repositoryWrapper.Activity
                .FindByCondition(x => x.ActivityId == id);
            return Activity.First();
        }

        public async Task Create(Activity model)
        {
            await _repositoryWrapper.Activity.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Activity model)
        {
            _repositoryWrapper.Activity.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var Activity = await _repositoryWrapper.Activity
                .FindByCondition(x => x.ActivityId == id);

            _repositoryWrapper.Activity.Delete(Activity.First());
            _repositoryWrapper.Save();
        }
    }
}