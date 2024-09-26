using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public практическая_работаContext Context {  get; }

        public UsersController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<User> user = Context.Users.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            User? user = Context.Users.Where(x => x.UserId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(User user)
        {
            Context.Users.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            User? user = Context.Users.Where(x=> x.UserId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.Users.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
