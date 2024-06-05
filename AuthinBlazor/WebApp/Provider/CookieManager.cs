using Blazored.SessionStorage;
using WebApp.Data.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApp.Provider
{
    public class CookieManager
    {
        private readonly ISessionStorageService _sessionStorage;

        public CookieManager(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public void Set(UserModel userModel)
        {
            //string cookieKey = GetKey();
            //if (!httpContextAccessor.HttpContext.Request.Cookies.ContainsKey(cookieKey))
            //{
            //    string cookieValue = Newtonsoft.Json.JsonConvert.SerializeObject(userModel);
            //    var option = new CookieOptions();
            //    option.Expires = DateTime.Now.AddMinutes(10);
            //    httpContextAccessor.HttpContext.Response.Cookies.Append(cookieKey, cookieValue, option);
            //}
        }

        public UserModel Get(IHttpContextAccessor httpContextAccessor)
        {
            UserModel user = new UserModel();
            string cookieKey = GetKey();

            if (httpContextAccessor.HttpContext.Request.Cookies[cookieKey] != null)
            {
                var value = httpContextAccessor.HttpContext.Request.Cookies[cookieKey].FirstOrDefault();
            }
            
            
            return null;
        }

        public void Delete(IHttpContextAccessor httpContextAccessor, UserModel userModel)
        {
            string cookieKey = GetKey();
            httpContextAccessor.HttpContext.Response.Cookies.Delete(cookieKey);
        }


        public void GetAndSetCookie(IHttpContextAccessor httpContextAccessor, UserModel userModel)
        {
            string cookieKey = GetKey();
            if (!httpContextAccessor.HttpContext.Request.Cookies.ContainsKey(cookieKey))
            {
                string cookieValue = Newtonsoft.Json.JsonConvert.SerializeObject(userModel);
                var option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(10);
                httpContextAccessor.HttpContext.Response.Cookies.Append(cookieKey, cookieValue, option);
            }
            else
            {
                var value = httpContextAccessor.HttpContext.Request.Cookies[cookieKey].FirstOrDefault();
            }
        }

        //public string GetKey(string email)
        public string GetKey()
        {
            //return "ECOMM_AUTH_COOKIE" + email.ToUpper();
            return "ECOMM_AUTH_COOKIE";
        }
    }
}
