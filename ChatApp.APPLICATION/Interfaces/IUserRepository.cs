using ChatApp.Application.Entities;

namespace ChatApp.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> isEmailTaken(string email);
        Task CreatedUser(User user);
    }
}
