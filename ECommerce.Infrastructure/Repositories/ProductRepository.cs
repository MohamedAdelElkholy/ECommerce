using Microsoft.EntityFrameworkCore;
using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Persistence;
using ECommerce.Domain.Entities;

namespace ECommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _Context;
        public ProductRepository(AppDbContext context)
        {
            _Context = context;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _Context.Products.ToListAsync();
        }
        public Task<Product?> GetByIdAsync(int id)
        {
            return _Context.Products.FirstOrDefaultAsync(p=>p.Id == id);
        }
        public async Task AddAsync(Product product)
        {
            await _Context.Products.AddAsync(product);
            await _Context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Product product)
        {
            _Context.Products.Update(product);
            await _Context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var product = await _Context.Products.FindAsync(id);
            if (product == null)
                return;
            _Context.Products.Remove(product);
            await _Context.SaveChangesAsync();
        }
    }
}
