using ChatApp.Application.Entities;

namespace ChatApp.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> isPhoneTaken(string email);
        Task CreatedUser(User user);
    }
}
