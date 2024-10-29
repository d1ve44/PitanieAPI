using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealFoodItemController : ControllerBase
    {
        private IMealFoodItemService _MealFoodItemService;
        public MealFoodItemController(IMealFoodItemService MealFoodItemService)
        {
            _MealFoodItemService = MealFoodItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _MealFoodItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _MealFoodItemService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(MealFoodItem MealFoodItem)
        {
            await _MealFoodItemService.Create(MealFoodItem);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(MealFoodItem MealFoodItem)
        {
            await _MealFoodItemService.Update(MealFoodItem);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _MealFoodItemService.Delete(id);
            return Ok();
        }
    }
}
