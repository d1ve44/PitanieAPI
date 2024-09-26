using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public RecipesController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Recipe> user = Context.Recipes.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Recipe? user = Context.Recipes.Where(x => x.RecipeId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(Recipe user)
        {
            Context.Recipes.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(Recipe user)
        {
            Context.Recipes.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Recipe? user = Context.Recipes.Where(x => x.RecipeId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.Recipes.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
