using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class PaymentOptions
    {
        [Key]
        public int PaymentOptionsID { get; set; }
        public int PaymentType { get; set; }

        public List<Order> Orders { get; set; }
    }
}
