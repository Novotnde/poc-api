using Poc.Logic.Models;
using Poc.Logic.Models.Mappers;
using Poc.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserPersistence _userPersistence;
        public UserService(IUserPersistence userPersistence)
        {
            _userPersistence = userPersistence;
        }
        public Task CreateUserAsync(User user)
        {
           return _userPersistence.SaveUserAsync(user.ToDto());
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            var result = await _userPersistence.GetUserByIdAsync(id);

            return result.FromDto();
        }
        
    }
}
