using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cargo
    {
        [Key]
        public int CargoID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescreption { get; set; }

        public List<Order> Orders { get; set; }
    }
}
