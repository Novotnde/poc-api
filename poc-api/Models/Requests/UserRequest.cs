﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Api.Models.Requests
{
    public class UserRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Id { get; set; }
    }
}
