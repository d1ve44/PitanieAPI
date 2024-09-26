using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Питание.Models;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListItemsController : ControllerBase
    {
        public практическая_работаContext Context { get; }

        public ShoppingListItemsController(практическая_работаContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ShoppingListItem> user = Context.ShoppingListItems.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ShoppingListItem? user = Context.ShoppingListItems.Where(x => x.ShoppingListItemId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найден");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add(ShoppingListItem user)
        {
            Context.ShoppingListItems.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Update(ShoppingListItem user)
        {
            Context.ShoppingListItems.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            ShoppingListItem? user = Context.ShoppingListItems.Where(x => x.ShoppingListItemId == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Не найдено");
            }
            Context.ShoppingListItems.Remove(user);
            Context.SaveChanges();
            return Ok(user);
        }
    }
}
