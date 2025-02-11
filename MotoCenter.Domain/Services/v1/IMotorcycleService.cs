using MotoCenter.Domain.Models.v1;

namespace MotoCenter.Domain.Services.v1
{
    public interface IMotorcycleRepository
    {
        Task<Motorcycle> GetByIdAsync(int id);
        Task<List<Motorcycle>> GetAllAsync();
        void Add(Motorcycle motorcycle);
        Task SaveChangesAsync();
    }
}