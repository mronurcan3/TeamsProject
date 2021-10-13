﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int? CategoryID { get; set; }

        public string ImagePath { get; set; }

        //Relational Properties

        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
