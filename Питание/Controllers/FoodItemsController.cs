using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private IFoodItemService _FoodItemService;
        public FoodItemController(IFoodItemService FoodItemService)
        {
            _FoodItemService = FoodItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _FoodItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _FoodItemService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FoodItem FoodItem)
        {
            await _FoodItemService.Create(FoodItem);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FoodItem FoodItem)
        {
            await _FoodItemService.Update(FoodItem);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _FoodItemService.Delete(id);
            return Ok();
        }
    }
}
