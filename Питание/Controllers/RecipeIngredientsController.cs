using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeIngredientController : ControllerBase
    {
        private IRecipeIngredientService _RecipeIngredientService;
        public RecipeIngredientController(IRecipeIngredientService RecipeIngredientService)
        {
            _RecipeIngredientService = RecipeIngredientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _RecipeIngredientService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _RecipeIngredientService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(RecipeIngredient RecipeIngredient)
        {
            await _RecipeIngredientService.Create(RecipeIngredient);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(RecipeIngredient RecipeIngredient)
        {
            await _RecipeIngredientService.Update(RecipeIngredient);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _RecipeIngredientService.Delete(id);
            return Ok();
        }
    }
}
