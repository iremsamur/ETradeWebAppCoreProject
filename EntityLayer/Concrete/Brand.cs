using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public string BrandLogo { get; set; }
        public bool BrandStatus { get; set; }

        //Bir ürünün bir markası olur ama bir markanın birden fazla ürünü olur. 1'e N ilişki var
        public List<Product> Products { get; set; } //Product Ve Brand arasındaki ilişki

    }
}
