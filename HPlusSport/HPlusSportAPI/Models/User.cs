﻿using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSportAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        
        public virtual List<Order> Orders { get; set; }

    }
}
