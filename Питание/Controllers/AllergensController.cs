using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergenController : ControllerBase
    {
        private IAllergenService _allergenService;
        public AllergenController(IAllergenService allergenService)
        {
            _allergenService = allergenService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _allergenService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _allergenService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Allergen allergen)
        {
            await _allergenService.Create(allergen);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Allergen allergen)
        {
            await _allergenService.Update(allergen);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _allergenService.Delete(id);
            return Ok();
        }
    }
}
