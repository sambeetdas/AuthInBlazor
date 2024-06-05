using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Model.DTOs;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApp.Provider
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly ISessionStorageService _sessionStorage;

        public CustomAuthStateProvider(ILocalStorageService localStorage, ISessionStorageService sessionStorage)
        {
            _localStorage = localStorage;
            _sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity = new ClaimsIdentity();
                       
            var userModel = await _localStorage.GetItemAsync<UserModel>("ECOMM_AUTH_COOKIE");
            if (userModel != null)
            {
                var claims = new Claim[]
                {
                    new Claim(ClaimTypes.Email, userModel.Email),
                    new Claim(ClaimTypes.Name, userModel.Name),
                    new Claim(ClaimTypes.Role, userModel.Role.ToUpper())
                };

                identity = new ClaimsIdentity(claims, "Ecomm_Auth_Type");
            }

            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));

        }

        public void MarkUserAsAuthenticated(UserModel userModel)
        {
            //_localStorage.SetItemAsync("ECOMM_AUTH_COOKIE", userModel);

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Email, userModel.Email),
                new Claim(ClaimTypes.Name, userModel.Name),
                new Claim(ClaimTypes.Role, userModel.Role.ToUpper())
            };

            var identity = new ClaimsIdentity(claims, "Ecomm_Auth_Type");

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsUnAuthenticated()
        {
            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
