using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemCategoryController : ControllerBase
    {
        private IFoodItemCategoryService _FoodItemCategoryService;
        public FoodItemCategoryController(IFoodItemCategoryService FoodItemCategoryService)
        {
            _FoodItemCategoryService = FoodItemCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _FoodItemCategoryService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _FoodItemCategoryService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FoodItemCategory FoodItemCategory)
        {
            await _FoodItemCategoryService.Create(FoodItemCategory);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FoodItemCategory FoodItemCategory)
        {
            await _FoodItemCategoryService.Update(FoodItemCategory);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _FoodItemCategoryService.Delete(id);
            return Ok();
        }
    }
}
