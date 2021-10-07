using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class InstallmentTable
    {
        [Key]
        public int InstallmentTableID { get; set; }
        public int InstallmentNumber { get; set; }
        public int InstallmentAmount { get; set; }
        public int TotalAmount { get; set; }
        //taksit tablosu taksit
        public Installments Installments { get; set; }
    }
}
