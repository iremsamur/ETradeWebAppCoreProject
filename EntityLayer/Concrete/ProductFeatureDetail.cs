using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductFeatureDetail
    {
        [Key]
        public int ProductFeatureDetailID { get; set; }
        public string ProductFeatureDetailDescription { get; set; }


        //1 Durumundaki Detail N durumundaki Feature olur. Yani Blog gibi Product gibi olan Detail kategori gibi olan Feature olur.

        //Detail Ve Feature arasındaki ilişki
        [ForeignKey("ProductFeature")]
        public int? ProductFeatureID { get; set; }
        public ProductFeature ProductFeature { get; set; }

    }
}
