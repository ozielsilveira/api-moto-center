using AutoMapper;
using MotoCenter.Application.Dtos.v1;
using MotoCenter.Domain.Models.v1;
using MotoCenter.Domain.Services.v1;

namespace MotoCenter.Application.Services.v1
{
    public class MotorcycleAppService(IMotorcycleRepository motorcycleRepository, IMapper mapper)
    {
        private readonly IMotorcycleRepository _motorcycleRepository = motorcycleRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<MotorcycleDto>> GetMotorcyclesAsync()
        {
            var motorcycles = await _motorcycleRepository.GetAllAsync();
            var motorcycleDtos = _mapper.Map<List<MotorcycleDto>>(motorcycles);

            return motorcycleDtos;
        }

        public async Task CreateMotorcycleAsync(MotorcycleDto motorcycleDto)
        {
            var motorcycle = _mapper.Map<Motorcycle>(motorcycleDto);

            _motorcycleRepository.Add(motorcycle);

            await _motorcycleRepository.SaveChangesAsync();
        }
    }
}
