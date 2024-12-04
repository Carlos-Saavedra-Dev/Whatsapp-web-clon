using BCrypt.Net;
using ChatApp.Application.DTOs;
using ChatApp.Application.Entities;
using ChatApp.Application.Interfaces;
using ChatApp.Core.Interfaces;

namespace ChatApp.Core.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> RegisterUser(UserRegisterDto userRegisterDto)
        {
            if (await _userRepository.isEmailTaken(userRegisterDto.Email)) 
            {
                throw new Exception("Email is already in use");
            }

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(userRegisterDto.Password);

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = userRegisterDto.Username,
                Email = userRegisterDto.Email,
                PasswordHash = hashedPassword

            };

            await _userRepository.CreatedUser(user);

            return true;
        }
    }
}
