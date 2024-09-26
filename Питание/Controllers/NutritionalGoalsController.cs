using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionalGoalsController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public NutritionalGoalsController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<NutritionalGoal> user = Context.NutritionalGoals.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            NutritionalGoal? user = Context.NutritionalGoals.Where(x => x.GoalId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(NutritionalGoal user)
        {
            Context.NutritionalGoals.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(NutritionalGoal user)
        {
            Context.NutritionalGoals.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            NutritionalGoal? user = Context.NutritionalGoals.Where(x => x.GoalId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.NutritionalGoals.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
