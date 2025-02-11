using Microsoft.AspNetCore.Mvc;
using MotoCenter.Application.Dtos.v1;
using MotoCenter.Application.Services.v1;

namespace MotoCenter.API.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class MotorcyclesController(MotorcycleAppService motorcycleAppService) : ControllerBase
    {
        private readonly MotorcycleAppService _motorcycleAppService = motorcycleAppService;

        [HttpGet("health-check")]        
        public IActionResult Get()
        {
            return Ok("API is working");
        }

        [HttpGet]
        public async Task<ActionResult<List<MotorcycleDto>>> GetMotorcycles()
        {
            var motorcycles = await _motorcycleAppService.GetMotorcyclesAsync();
            return Ok(motorcycles);
        }

        [HttpPost]
        public async Task<ActionResult> CreateMotorcycle(MotorcycleDto motorcycleDto)
        {
            await _motorcycleAppService.CreateMotorcycleAsync(motorcycleDto);
            return CreatedAtAction(nameof(GetMotorcycles), new { model = motorcycleDto.Model }, motorcycleDto);
        }
    }
}
