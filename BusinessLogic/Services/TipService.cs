﻿using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class TipService : ITipService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TipService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Tip>> GetAll()
        {
            return await _repositoryWrapper.Tip.FindAll();
        }

        public async Task<Tip> GetById(int id)
        {
            var Tip = await _repositoryWrapper.Tip
                .FindByCondition(x => x.TipId == id);
            return Tip.First();
        }

        public async Task Create(Tip model)
        {
            await _repositoryWrapper.Tip.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Tip model)
        {
            _repositoryWrapper.Tip.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var Tip = await _repositoryWrapper.Tip
                .FindByCondition(x => x.TipId == id);

            _repositoryWrapper.Tip.Delete(Tip.First());
            _repositoryWrapper.Save();
        }
    }
}