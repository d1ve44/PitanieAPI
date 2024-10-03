using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class RecordService : IRecordService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RecordService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Record>> GetAll()
        {
            return await _repositoryWrapper.Record.FindAll();
        }

        public async Task<Record> GetById(int id)
        {
            var Record = await _repositoryWrapper.Record
                .FindByCondition(x => x.RecordId == id);
            return Record.First();
        }

        public async Task Create(Record model)
        {
            await _repositoryWrapper.Record.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Record model)
        {
            _repositoryWrapper.Record.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var Record = await _repositoryWrapper.Record
                .FindByCondition(x => x.RecordId == id);

            _repositoryWrapper.Record.Delete(Record.First());
            _repositoryWrapper.Save();
        }
    }
}