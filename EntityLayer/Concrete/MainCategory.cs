using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MainCategory
    {
        [Key]
        public int MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
        public bool MainCategoryStatus { get; set; }
        public List<Product> Products { get; set; }
        public List<SubCategory> SubCategories { get; set; }


        //Main Category Ve Sub Category Arasında 1'E N ilişki var 
    }
}
