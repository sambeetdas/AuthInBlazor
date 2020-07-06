using EComm_Blazor.Data.Model;
using EComm_Blazor.Data.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm_Blazor.Data.Service.IRepository
{
    interface IUserRepository
    {
        Task<UserModel> SignIn(UserModel userModel);
    }
}
