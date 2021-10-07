namespace Family.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}