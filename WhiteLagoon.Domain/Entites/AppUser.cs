﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entites
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }    
        public DateTime CreatedAt { get; set; } 
    }
}
