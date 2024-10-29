using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private IRecipeService _RecipeService;
        public RecipeController(IRecipeService RecipeService)
        {
            _RecipeService = RecipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _RecipeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _RecipeService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Recipe Recipe)
        {
            await _RecipeService.Create(Recipe);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Recipe Recipe)
        {
            await _RecipeService.Update(Recipe);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _RecipeService.Delete(id);
            return Ok();
        }
    }
}
