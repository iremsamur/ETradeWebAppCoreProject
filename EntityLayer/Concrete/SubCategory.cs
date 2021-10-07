using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubCategory
    {
        //alt kategoriler
        [Key]
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        //Main Ve Sub Arasındaki İlişki
        [ForeignKey("MainCategory")]
        public int MainCategoryID { get; set; }
        public MainCategory MainCategory { get; set; }

    }
}
