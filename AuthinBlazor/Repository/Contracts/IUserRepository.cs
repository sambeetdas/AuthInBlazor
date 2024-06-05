using Model.DTOs;
using Model.Entities;

namespace Repository.Contracts
{
    public interface IUserRepository
    {
        Task<UserEntity> GetUserByEmailAndPassword(string email, string password);
    }
}
