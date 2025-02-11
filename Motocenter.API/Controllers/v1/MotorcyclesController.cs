using Microsoft.AspNetCore.Mvc;
using MotoCenter.Application.Dtos.v1;
using MotoCenter.Application.Services.v1;

namespace MotoCenter.API.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class MotorcyclesController : ControllerBase
    {
        private readonly MotorcycleAppService _motorcycleAppService;

        public MotorcyclesController(MotorcycleAppService motorcycleAppService)
        {
            _motorcycleAppService = motorcycleAppService;
        }

        [HttpGet("health-check")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok("API is working");
        }

        [HttpGet]
        [ProducesResponseType(typeof(MotorcycleDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<MotorcycleDto>>> GetMotorcycles()
        {
            var motorcycles = await _motorcycleAppService.GetMotorcyclesAsync();
            return Ok(motorcycles);
        }

        [HttpPost]
        [ProducesResponseType(typeof(MotorcycleDto), StatusCodes.Status200OK)]
        public async Task<ActionResult> CreateMotorcycle(MotorcycleDto motorcycleDto)
        {
            await _motorcycleAppService.CreateMotorcycleAsync(motorcycleDto);
            return CreatedAtAction(nameof(GetMotorcycles), new { model = motorcycleDto.Model }, motorcycleDto);
        }
    }
}
