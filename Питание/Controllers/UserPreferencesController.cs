using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Питание.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPreferenceController : ControllerBase
    {
        private IUserPreferenceService _UserPreferenceService;
        public UserPreferenceController(IUserPreferenceService UserPreferenceService)
        {
            _UserPreferenceService = UserPreferenceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _UserPreferenceService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _UserPreferenceService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserPreference UserPreference)
        {
            await _UserPreferenceService.Create(UserPreference);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserPreference UserPreference)
        {
            await _UserPreferenceService.Update(UserPreference);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _UserPreferenceService.Delete(id);
            return Ok();
        }
    }
}
