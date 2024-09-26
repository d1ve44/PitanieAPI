using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemCategoriesController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public FoodItemCategoriesController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<FoodItemCategory> user = Context.FoodItemCategories.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            FoodItemCategory? user = Context.FoodItemCategories.Where(x => x.FoodItemCategoryId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(FoodItemCategory user)
        {
            Context.FoodCategories.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(FoodItemCategory user)
        {
            Context.FoodItemCategories.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            FoodItemCategory? user = Context.FoodItemCategories.Where(x => x.FoodItemCategoryId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.FoodItemCategories.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
