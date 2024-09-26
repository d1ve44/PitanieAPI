using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteRecipesController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public FavoriteRecipesController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<FavoriteRecipe> user = Context.FavoriteRecipes.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            FavoriteRecipe? user = Context.FavoriteRecipes.Where(x => x.FavoriteRecipeId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(FavoriteRecipe user)
        {
            Context.FavoriteRecipes.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(FavoriteRecipe user)
        {
            Context.FavoriteRecipes.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            FavoriteRecipe? user = Context.FavoriteRecipes.Where(x => x.FavoriteRecipeId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.FavoriteRecipes.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
