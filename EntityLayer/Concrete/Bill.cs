using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bill
    {
        [Key]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        [ForeignKey("AddressDefinition")]

        public int AddressDefinitionID { get; set; }
        public AddressDefinition AddressDefinition { get; set; }
    }
}
