using Microsoft.AspNetCore.Mvc;
using MotoCenter.Application.Dtos.v1;
using MotoCenter.Application.Services.v1;

namespace MotoCenter.API.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotorcyclesController : ControllerBase
    {
        private readonly MotorcycleAppService _motorcycleAppService;

        public MotorcyclesController(MotorcycleAppService motorcycleAppService)
        {
            _motorcycleAppService = motorcycleAppService;
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
