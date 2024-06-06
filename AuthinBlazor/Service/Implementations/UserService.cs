using Model.DTOs;
using Repository.Contracts;
using Repository.Implementations;
using Service.Contracts;

namespace Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public Task<UserModel> AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        //CookieManager cookieMgr = new CookieManager();
        public async Task<UserModel?> ValidUser(UserModel user)
        {
            var validUser = await _userRepository.GetUserByEmailAndPassword(user.Email, user.Password);

            if (validUser != null)
            {
                //For Security
                user.Password = string.Empty;

                user.Name = validUser.Name;
                user.Role = validUser.Role;

                return user;
            }
            return null;
            
        }
    }
}
