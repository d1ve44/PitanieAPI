using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private IMealService _MealService;
        public MealController(IMealService MealService)
        {
            _MealService = MealService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _MealService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _MealService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Meal Meal)
        {
            await _MealService.Create(Meal);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Meal Meal)
        {
            await _MealService.Update(Meal);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _MealService.Delete(id);
            return Ok();
        }
    }
}
