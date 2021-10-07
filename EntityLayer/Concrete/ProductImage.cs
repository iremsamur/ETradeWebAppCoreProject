using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }
        public string ImagePath { get; set; }
        public string CatalogImage { get; set; }
        public string SlideImage { get; set; }

        //Product Ve ProductImage ilişkisi
        [ForeignKey("Product")]
        public int? ProductID { get; set; }
        public Product Product { get; set; }

    }
}
