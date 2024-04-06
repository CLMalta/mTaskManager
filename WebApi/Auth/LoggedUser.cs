namespace WebApi.Auth
{
    public class LoggedUser : IUser
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public LoggedUser(int userId, string userName, string email)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
        }
    }
}
