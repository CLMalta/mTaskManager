namespace WebApi.Auth
{
    public interface IUser
    {
        int UserId { get; }
        string UserName { get; }
        string Email { get; }
    }
}
