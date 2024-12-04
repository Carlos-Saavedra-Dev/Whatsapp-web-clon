
using ChatApp.Application.DTOs;

namespace ChatApp.Core.Interfaces
{
    public interface IUserService
    {
        public Task<bool> RegisterUser(UserRegisterDto userRegisterDto);
    }
}
