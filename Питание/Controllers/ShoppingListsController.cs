using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private IShoppingListService _ShoppingListService;
        public ShoppingListController(IShoppingListService ShoppingListService)
        {
            _ShoppingListService = ShoppingListService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _ShoppingListService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ShoppingListService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShoppingList ShoppingList)
        {
            await _ShoppingListService.Create(ShoppingList);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShoppingList ShoppingList)
        {
            await _ShoppingListService.Update(ShoppingList);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _ShoppingListService.Delete(id);
            return Ok();
        }
    }
}
