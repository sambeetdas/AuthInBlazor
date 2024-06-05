using Model.DTOs;
using Repository.Contracts;
using Repository.Implementations;
using Service.Contracts;

namespace Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        //private readonly ISessionStorageService _sessionStorage;
        public UserService(IUserRepository userRepository
            //,ISessionStorageService sessionStorage
            ) 
        {
            _userRepository = userRepository;
            //_sessionStorage = sessionStorage;
        }

        public Task<UserModel> AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        //CookieManager cookieMgr = new CookieManager();
        public async Task<UserModel?> ValidUser(UserModel user)
        {
            var validUser = await _userRepository.GetUserByEmailAndPassword(user.Name, user.Password);

            if (validUser != null)
            {
                //For Security
                user.Password = string.Empty;

                //Add to UserModel to Cookie
                //_sessionStorage.SetItemAsync("ECOMM_AUTH_COOKIE", Newtonsoft.Json.JsonConvert.SerializeObject(validatedUser));
                //cookieMgr.Set(_httpContextAccessor, validatedUser);

                return user;
            }
            return null;
            
        }
    }
}
