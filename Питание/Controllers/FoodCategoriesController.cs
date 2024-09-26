using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodCategoriesController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public FoodCategoriesController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<FoodCategory> user = Context.FoodCategories.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            FoodCategory? user = Context.FoodCategories.Where(x => x.FoodCategoryId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(FoodCategory user)
        {
            Context.FoodCategories.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(FoodCategory user)
        {
            Context.FoodCategories.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            FoodCategory? user = Context.FoodCategories.Where(x => x.FoodCategoryId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.FoodCategories.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
