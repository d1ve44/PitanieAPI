using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipController : ControllerBase
    {
        private ITipService _TipService;
        public TipController(ITipService TipService)
        {
            _TipService = TipService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _TipService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _TipService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Tip Tip)
        {
            await _TipService.Create(Tip);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Tip Tip)
        {
            await _TipService.Update(Tip);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _TipService.Delete(id);
            return Ok();
        }
    }
}
