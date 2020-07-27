using Poc.Persistence.Contracts.Entitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Logic.Models.Mappers
{
    internal static class UserMapper
    {
        internal static User FromDto(this UserDto userDto)
        {
            var user = new User
            {
                Id = userDto.Id,
                Name = userDto.Name
            };
            return user;
        }

        internal static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name
            };

        }
    }
}
