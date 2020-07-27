using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Api.Models.Responses
{
    public class UserResponse
    {
        public UserResponse(string name, string id)
        {
            Name = name;
            Id = id;
        }

        [Required]
        public string Name { get; }

        [Required]
        public string Id { get; }
    }
}
