using Blazored.SessionStorage;
using EComm_Blazor.Data.Model;
using EComm_Blazor.Data.Service.IRepository;
using EComm_Blazor.Provider;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm_Blazor.Data.Service.Repository
{
    public class UserRepository : IUserRepository
    {
        //private readonly ISessionStorageService _sessionStorage;

        //public UserRepository(ISessionStorageService sessionStorage)
        //{
        //    _sessionStorage = sessionStorage;
        //}

        //CookieManager cookieMgr = new CookieManager();
        public Task<UserModel> SignIn(UserModel userModel)
        {
            var validatedUser = GetUser().FirstOrDefault(index => index.Email == userModel.Email && index.Password == userModel.Password);

            if (validatedUser != null)
            {
                validatedUser.IsLoggedIn = true;
                
                //For Security
                validatedUser.Password = string.Empty;

                //Add to UserModel to Cookie
                //_sessionStorage.SetItemAsync("ECOMM_AUTH_COOKIE", Newtonsoft.Json.JsonConvert.SerializeObject(validatedUser));
                //cookieMgr.Set(_httpContextAccessor, validatedUser);
            }

            return Task.FromResult<UserModel>(validatedUser);
        }


        private List<UserModel> GetUser()
        {
            var users = new List<UserModel>() {
                new UserModel{
                    Email = "sambeet@ess.com",
                    Name = "Sambeet",
                    Password = "sam@111",
                    Role = "Admin"
                },
                 new UserModel{
                    Email = "kirti@ess.com",
                    Name = "Kirti",
                    Password = "kirti@222",
                    Role = "Normal"
                },
                  new UserModel{
                    Email = "sipra@ess.com",
                    Name = "Sipra",
                    Password = "sipra@333",
                    Role = "Normal"
                }
            };
            return users;
        }
    }
}
