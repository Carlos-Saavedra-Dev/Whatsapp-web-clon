using ChatApp.Application.Entities;
using ChatApp.Application.Interfaces;
using ChatApp.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ChatAppDbContext _context;

        public UserRepository(ChatAppDbContext context)
        { 
            _context = context;
        }

        public async Task<bool> isEmailTaken (string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task CreatedUser(User user)
        {
            _context.Users.Add(user);

            await _context.SaveChangesAsync();
        }
    }
}
