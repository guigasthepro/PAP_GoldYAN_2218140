﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdmin2.Data
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password  { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
}
