using Poc.Persistence.Contracts.Entitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Persistence.Contracts
{ 
    //abstrakce k referenci
    public interface IUserPersistence
    {
       Task<UserDto> GetUserByIdAsync(string id);

        Task SaveUserAsync(UserDto userDto);
    }
}
