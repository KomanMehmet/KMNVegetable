using KMNVetetable.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using static KMNVegetable.Application.Interfaces.IRepository;

namespace KMNVetetable.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly KmnContext _context;

        public Repository(KmnContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
