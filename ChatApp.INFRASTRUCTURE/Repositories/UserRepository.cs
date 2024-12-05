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

        public async Task<bool> isPhoneTaken (string PhoneNumber)
        {
            return await _context.Users.AnyAsync(u => u.PhoneNumber == PhoneNumber);
        }

        public async Task CreatedUser(User user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }
    }
}
