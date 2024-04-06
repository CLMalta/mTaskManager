using Domain.Models;
namespace WebApi.Auth
{
    public class LoggedUser : IUser
    {
        public int UserId { get; private set; }

        public string UserName { get; private set; }

        public string Email { get; private set; }

        public UserRole Role { get; private set; }

        public LoggedUser(int userId, string userName, string email, UserRole role)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Role = role;
        }
    }
}
