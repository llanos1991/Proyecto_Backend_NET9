using Microsoft.EntityFrameworkCore;
using Backend.Core.Entities;
using Backend.Core.Repositories;

namespace Backend.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) => _context = context;

        public async Task<IEnumerable<Product>> GetAllAsync()
            => await _context.Products.Include(p => p.Category).ToListAsync();

        public async Task<Product?> GetByIdAsync(int id)
            => await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Products.FindAsync(id);
            if (entity != null)
            {
                _context.Products.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
