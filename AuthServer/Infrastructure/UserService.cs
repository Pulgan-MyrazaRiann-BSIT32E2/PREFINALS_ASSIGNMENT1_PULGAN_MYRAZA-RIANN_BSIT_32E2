using AuthServer.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Infrastructure
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public Task<User> Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(u => u.Username == username && u.PasswordHash == HashPassword(password));
            return Task.FromResult(user);
        }

        public Task<User> Register(string username, string password)
        {
            var user = new User { Username = username, PasswordHash = HashPassword(password) };
            _users.Add(user);
            return Task.FromResult(user);
        }

        private string HashPassword(string password)
        {
            // Implement password hashing
            return password; // Simplified for example purposes
        }
    }
}