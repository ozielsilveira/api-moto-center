using Microsoft.EntityFrameworkCore;
using MotoCenter.Domain.Models.v1;
using MotoCenter.Domain.Services.v1;
using MotoCenter.Infrastructure.Context.v1;

namespace MotoCenter.Infrastructure.Repositories.v1
{
    public class MotorcycleRepository(AppDbContext context) : IMotorcycleRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<Motorcycle> GetByIdAsync(int id)
        {
            return await _context.Motorcycles
                .Include(m => m.Photos)
                .Include(m => m.MotorcycleCategories)
                .FirstOrDefaultAsync(m => m.Id == id) ?? throw new InvalidOperationException("Motorcycle not found");
        }

        public async Task<List<Motorcycle>> GetAllAsync()
        {
            return await _context.Motorcycles
                .Include(m => m.Photos)
                .Include(m => m.MotorcycleCategories)
                .ToListAsync();
        }

        public void Add(Motorcycle motorcycle)
        {
            _context.Motorcycles.Add(motorcycle);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
