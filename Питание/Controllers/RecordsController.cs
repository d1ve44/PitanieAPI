using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private IRecordService _RecordService;
        public RecordController(IRecordService RecordService)
        {
            _RecordService = RecordService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _RecordService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _RecordService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Record Record)
        {
            await _RecordService.Create(Record);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Record Record)
        {
            await _RecordService.Update(Record);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _RecordService.Delete(id);
            return Ok();
        }
    }
}
