using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPreferencesController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public UserPreferencesController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<UserPreference> user = Context.UserPreferences.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            UserPreference? user = Context.UserPreferences.Where(x => x.UserPreferenceId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(UserPreference user)
        {
            Context.UserPreferences.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(UserPreference user)
        {
            Context.UserPreferences.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            UserPreference? user = Context.UserPreferences.Where(x => x.UserPreferenceId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.UserPreferences.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
