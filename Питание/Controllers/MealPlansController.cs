using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanController : ControllerBase
    {
        private IMealPlanService _MealPlanService;
        public MealPlanController(IMealPlanService MealPlanService)
        {
            _MealPlanService = MealPlanService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _MealPlanService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _MealPlanService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(MealPlan MealPlan)
        {
            await _MealPlanService.Create(MealPlan);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(MealPlan MealPlan)
        {
            await _MealPlanService.Update(MealPlan);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _MealPlanService.Delete(id);
            return Ok();
        }
    }
}
