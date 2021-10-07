using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class District
    {
        [Key]
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        [ForeignKey("City")]

        public int? CityID { get; set; }
        public City City { get; set; }

        public List<User> Users { get; set; }
        
    }
}
