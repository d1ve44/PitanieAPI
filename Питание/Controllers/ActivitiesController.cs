using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.Interfaces;

namespace Питание.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _activityService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _activityService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Activity activity)
        {
            await _activityService.Create(activity);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Activity activity)
        {
            await _activityService.Update(activity);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _activityService.Delete(id);
            return Ok();
        }
    }
}
