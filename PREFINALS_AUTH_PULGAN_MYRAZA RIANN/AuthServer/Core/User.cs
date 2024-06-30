namespace AuthServer.Core
{
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        // Additional properties like Email, Role, etc.
    }
}
