﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Domain.DTOs.User
{
    public class LoginDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public enum LoginResult
    {
        Success,
        Error,
        UserNotFound
    }
}
