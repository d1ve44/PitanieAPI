using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodAllergensController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public FoodAllergensController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<FoodAllergen> user = Context.FoodAllergens.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            FoodAllergen? user = Context.FoodAllergens.Where(x => x.FoodAllergenId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(FoodAllergen user)
        {
            Context.FoodAllergens.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(FoodAllergen user)
        {
            Context.FoodAllergens.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            FoodAllergen? user = Context.FoodAllergens.Where(x => x.FoodAllergenId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.FoodAllergens.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
