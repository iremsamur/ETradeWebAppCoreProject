using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int? ProductID { get; set; }
        public Product Product { get; set; }

        [ForeignKey("OrderStatus")]
        public int? OrderStatusID { get; set; }
        public OrderStatus OrderStatus { get; set; }

        [ForeignKey("PaymentOptions")]
        public int? PaymentOptionsID { get; set; }
        public PaymentOptions PaymentOptions { get; set; }

        [ForeignKey("Installments")]
        public int? InstallmentID { get; set; }
        public Installments Installments { get; set; }



        public DateTime OrderDate { get; set; }

        public int? CargoID { get; set; }
        public Cargo Cargo { get; set; }


        public string CargoNo { get; set; }
        public DateTime ProjectedDeliveryDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
