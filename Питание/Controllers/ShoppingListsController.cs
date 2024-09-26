using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListsController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public ShoppingListsController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ShoppingList> user = Context.ShoppingLists.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ShoppingList? user = Context.ShoppingLists.Where(x => x.ShoppingListId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(ShoppingList user)
        {
            Context.ShoppingLists.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(ShoppingList user)
        {
            Context.ShoppingLists.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            ShoppingList? user = Context.ShoppingLists.Where(x => x.ShoppingListId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.ShoppingLists.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
