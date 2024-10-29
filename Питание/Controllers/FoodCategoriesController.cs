using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodCategoryController : ControllerBase
    {
        private IFoodCategoryService _FoodCategoryService;
        public FoodCategoryController(IFoodCategoryService FoodCategoryService)
        {
            _FoodCategoryService = FoodCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _FoodCategoryService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _FoodCategoryService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FoodCategory FoodCategory)
        {
            await _FoodCategoryService.Create(FoodCategory);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FoodCategory FoodCategory)
        {
            await _FoodCategoryService.Update(FoodCategory);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _FoodCategoryService.Delete(id);
            return Ok();
        }
    }
}
