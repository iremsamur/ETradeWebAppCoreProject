using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public List<City> cities { get; set; }

        public List<User> Users { get; set; }
        public List<AddressDefinition> AddressDefinitions { get; set; }
    }
}
