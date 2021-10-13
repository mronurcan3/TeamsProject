using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Shipper:BaseEntity
    {
        public string Name { get; set; }

        //Relatinal Properties

        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
