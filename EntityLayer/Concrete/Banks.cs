using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Banks
    {
        [Key]
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string BankLogo { get; set; }
        //banka taksit ilişkisi
        public Installments Installments{ get; set; }
    }
}
