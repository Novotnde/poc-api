using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Poc.Api.Models.Requests;
using Poc.Api.Models.Responses;
using Poc.Logic;
using Poc.Logic.Models;

namespace Poc.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")] // route parametr co ma byt slozene v url
        public async Task<UserResponse> Get(string id)
        {
            var result = await _userService.GetUserByIdAsync(id);

            return new UserResponse(result.Name, result.Id);
        }


        [HttpPost] // neco vztvari a posilam objekt v body
        public Task Create([FromBody]UserRequest userRequest)
        {
            var user = new User
            {
                Name = userRequest.Name,
                Id = userRequest.Id
            };

            return _userService.CreateUserAsync(user);


        }
    }
}
