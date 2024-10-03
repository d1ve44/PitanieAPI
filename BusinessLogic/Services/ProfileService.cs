using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class ProfileService : IProfileService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ProfileService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Profile>> GetAll()
        {
            return await _repositoryWrapper.Profile.FindAll();
        }

        public async Task<Profile> GetById(int id)
        {
            var Profile = await _repositoryWrapper.Profile
                .FindByCondition(x => x.ProfileId == id);
            return Profile.First();
        }

        public async Task Create(Profile model)
        {
            await _repositoryWrapper.Profile.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Profile model)
        {
            _repositoryWrapper.Profile.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var Profile = await _repositoryWrapper.Profile
                .FindByCondition(x => x.ProfileId == id);

            _repositoryWrapper.Profile.Delete(Profile.First());
            _repositoryWrapper.Save();
        }
    }
}