using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodAllergenController : ControllerBase
    {
        private IFoodAllergenService _FoodAllergenService;
        public FoodAllergenController(IFoodAllergenService FoodAllergenService)
        {
            _FoodAllergenService = FoodAllergenService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _FoodAllergenService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _FoodAllergenService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(FoodAllergen FoodAllergen)
        {
            await _FoodAllergenService.Create(FoodAllergen);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(FoodAllergen FoodAllergen)
        {
            await _FoodAllergenService.Update(FoodAllergen);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _FoodAllergenService.Delete(id);
            return Ok();
        }
    }
}
