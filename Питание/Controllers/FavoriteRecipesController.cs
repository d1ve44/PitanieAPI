using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteRecipeController : ControllerBase
    {
        private IFavoriteRecipeService _FavoriteRecipeService;
        public FavoriteRecipeController(IFavoriteRecipeService FavoriteRecipeService)
        {
            _FavoriteRecipeService = FavoriteRecipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _FavoriteRecipeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _FavoriteRecipeService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FavoriteRecipe FavoriteRecipe)
        {
            await _FavoriteRecipeService.Create(FavoriteRecipe);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FavoriteRecipe FavoriteRecipe)
        {
            await _FavoriteRecipeService.Update(FavoriteRecipe);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _FavoriteRecipeService.Delete(id);
            return Ok();
        }
    }
}
