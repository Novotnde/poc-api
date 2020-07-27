using Microsoft.Extensions.Caching.Memory;
using Poc.Persistence.Contracts;
using Poc.Persistence.Contracts.Entitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Persistence.InMemory
{
    public class UserPersistence : IUserPersistence
    {
        private readonly IMemoryCache _cache;

        public UserPersistence(IMemoryCache memoryCache)
        {

            _cache = memoryCache;
        }
        public Task<UserDto> GetUserByIdAsync(string id)
        {
           var result = _cache.Get<UserDto>(id);

           return Task.FromResult(result);
        }

        public Task SaveUserAsync(UserDto userDto)
        {
            _cache.Set<UserDto>(userDto.Id, userDto);

            return Task.CompletedTask;
        }
    }
}
