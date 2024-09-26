using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealFoodItemsController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public MealFoodItemsController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<MealFoodItem> user = Context.MealFoodItems.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            MealFoodItem? user = Context.MealFoodItems.Where(x => x.MealFoodItemId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(MealFoodItem user)
        {
            Context.MealFoodItems.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(MealFoodItem user)
        {
            Context.MealFoodItems.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            MealFoodItem? user = Context.MealFoodItems.Where(x => x.MealFoodItemId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.MealFoodItems.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
