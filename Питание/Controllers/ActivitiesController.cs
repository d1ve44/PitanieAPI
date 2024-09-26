using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public ActivitiesController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Activity> user = Context.Activities.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Activity? user = Context.Activities.Where(x => x.ActivityId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(Activity user)
        {
            Context.Activities.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(Activity user)
        {
            Context.Activities.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Activity? user = Context.Activities.Where(x => x.ActivityId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.Activities.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
