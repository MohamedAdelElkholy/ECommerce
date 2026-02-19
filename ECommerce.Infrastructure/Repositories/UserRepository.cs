using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _Context;
        public UserRepository(AppDbContext context)
        {
            _Context = context;
        }
        public async Task<User?> GetByIdAsync(int id)
        {
            var User = await _Context.Users.FindAsync(id);
            return User;
        }
        public async Task<User?> GetByEmailAsync(string email)
        {
            var User = await _Context.Users.FirstOrDefaultAsync(x => x.Email == email);
            return User;
        }
        public async Task AddAsync(User user)
        {
            await _Context.Users.AddAsync(user);
            await _Context.SaveChangesAsync();
        }
        public async Task UpdateAsync(User user)
        {
            _Context.Users.Update(user);
            await _Context.SaveChangesAsync();
        }
        public async Task DeleteAsync(User user)
        {
            _Context.Users.Remove(user);
            await _Context.SaveChangesAsync();
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _Context.Users.ToListAsync();
        }
    }
}
