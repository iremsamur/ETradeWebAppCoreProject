using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AddressDefinition
    {
        [Key]
        public int AddressDefinitionID { get; set; }

       


        public string AddressDescription { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Company { get; set; }
        public string TcIdentificationNumber { get; set; }
        public string TaxAdministration { get; set; }
        public int TaxNo { get; set; }
        public long MobileNumber { get; set; }
        public long PhoneNumber { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public User User { get; set; }
        public List<Country> Countries;

        public List<Bill> Bills { get; set; }
    }
}
