using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }
        public int ReservationPeriod { get; set; }
        [ForeignKey("Product")]
        public int? ProductID { get; set; }

        public Product Product { get; set; }

    }
}
