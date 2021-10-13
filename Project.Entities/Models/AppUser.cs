﻿using Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public UserRole Role { get; set; }

        //Relational Properties

        public virtual UserProfile UserProfile { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}
