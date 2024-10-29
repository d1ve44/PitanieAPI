using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionalGoalController : ControllerBase
    {
        private INutritionalGoalService _NutritionalGoalService;
        public NutritionalGoalController(INutritionalGoalService NutritionalGoalService)
        {
            _NutritionalGoalService = NutritionalGoalService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _NutritionalGoalService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _NutritionalGoalService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(NutritionalGoal NutritionalGoal)
        {
            await _NutritionalGoalService.Create(NutritionalGoal);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(NutritionalGoal NutritionalGoal)
        {
            await _NutritionalGoalService.Update(NutritionalGoal);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _NutritionalGoalService.Delete(id);
            return Ok();
        }
    }
}
