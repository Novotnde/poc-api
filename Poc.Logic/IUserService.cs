using Poc.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Logic
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(string id);

        Task CreateUserAsync(User user);

    }
}
