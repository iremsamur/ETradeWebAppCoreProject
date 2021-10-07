using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusID { get; set; }
        public bool Status { get; set; }

        public List<Order> Orders { get; set; }
    }
}
