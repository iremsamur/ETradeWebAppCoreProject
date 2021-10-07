using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        [ForeignKey("Country")]

        public int? CountryID { get; set; }
        public Country Country { get; set; }

        public List<District> Districts { get; set; }//her şehirde birden fazla semt olabilir. çok olan district tek olan city
        public List<User> Users { get; set; }
       
    }
}
