﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Contracts.Authentication
{
    public record LoginRequest(
        string Email,
        string Password
    );
}
