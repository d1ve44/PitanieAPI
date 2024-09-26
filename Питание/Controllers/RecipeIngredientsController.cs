using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeIngredientsController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public RecipeIngredientsController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<RecipeIngredient> user = Context.RecipeIngredients.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            RecipeIngredient? user = Context.RecipeIngredients.Where(x => x.RecipeIngredientId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(RecipeIngredient user)
        {
            Context.RecipeIngredients.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(RecipeIngredient user)
        {
            Context.RecipeIngredients.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            RecipeIngredient? user = Context.RecipeIngredients.Where(x => x.RecipeIngredientId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.RecipeIngredients.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
