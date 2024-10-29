using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListItemController : ControllerBase
    {
        private IShoppingListItemService _ShoppingListItemService;
        public ShoppingListItemController(IShoppingListItemService ShoppingListItemService)
        {
            _ShoppingListItemService = ShoppingListItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _ShoppingListItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ShoppingListItemService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShoppingListItem ShoppingListItem)
        {
            await _ShoppingListItemService.Create(ShoppingListItem);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShoppingListItem ShoppingListItem)
        {
            await _ShoppingListItemService.Update(ShoppingListItem);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _ShoppingListItemService.Delete(id);
            return Ok();
        }
    }
}
