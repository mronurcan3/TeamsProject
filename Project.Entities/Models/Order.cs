﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Order:BaseEntity
    {
        public string ShippedAddress  { get; set; }

        public decimal TotalPrice { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public int? AppUserID { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
