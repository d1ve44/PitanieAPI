using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IProfileService _ProfileService;
        public ProfileController(IProfileService ProfileService)
        {
            _ProfileService = ProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _ProfileService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ProfileService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Profile Profile)
        {
            await _ProfileService.Create(Profile);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Profile Profile)
        {
            await _ProfileService.Update(Profile);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _ProfileService.Delete(id);
            return Ok();
        }
    }
}
