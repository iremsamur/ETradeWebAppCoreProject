using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Installments
    {
        [Key]
        public int InstallmentID { get; set; }
        //taksit banka
        [ForeignKey("Banks")]
        public int BankID { get; set; }
        public Banks Banks { get; set; }
        //taksit ürün
        [ForeignKey("Product")]
        public int? ProductID { get; set; }
        public Product Product { get; set; }
        //taksit taksit tablosu
        [ForeignKey("InstallmentTable")]
        public int? InstallmentTableID { get; set; }
        public InstallmentTable InstallmentTable { get; set; }

        public List<Order> Orders { get; set; }
    }
}
