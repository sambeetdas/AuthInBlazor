using WebApp.Data.Model;
using WebApp.Data.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Service.IRepository
{
    interface IUserRepository
    {
        Task<UserModel> SignIn(UserModel userModel);
    }
}
