using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductFeature
    {
        [Key]
        public int ProductFeatureID { get; set; }
        public string ProductFeatureName { get; set; }
        /*bununla Product,ProductFeature arasında ilişki var
      * Her product'ın birden fazla özelliği olabilir. Ama her özellikte birden fazla ürünün olabilir Çoka çok ilişki
      */
        public List<Product> Products { get; set; }//çoka çok ilişki
        //Her özelliğin birden fazla detayı olur. ama her detay bir özelliğin olur.
        public List<ProductFeatureDetail> ProductFeatureDetails { get; set; }
    }
}
