using Model.DTOs;
using Model.Entities;
using Repository.Contracts;

namespace Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        public Task<UserEntity> GetUserByEmailAndPassword(string email, string password)
        {
            var user = GetUser().FirstOrDefault(index => index.Email.Trim().ToLower() == email && index.Password == password.Trim());
            
            return Task.FromResult<UserEntity>(user);
        }
        private static List<UserEntity> GetUser()
        {
            var users = new List<UserEntity>() {
                new UserEntity{
                    Email = "test1@ess.com",
                    Name = "Test 1",
                    Password = "test1",
                    Role = "Admin"
                },
                 new UserEntity{
                   Email = "test2@ess.com",
                    Name = "Test 2",
                    Password = "test2",
                    Role = "Normal"
                },
                  new UserEntity{
                   Email = "test3@ess.com",
                    Name = "Test 3",
                    Password = "test3",
                    Role = "Normal"
                }
            };
            return users;
        }
    }
}
