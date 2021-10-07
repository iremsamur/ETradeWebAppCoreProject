using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductPrice
    {
        [Key]
        public int ProductPriceID { get; set; }
        public double PurchasePrice { get; set; }//alış fiyatı
        public double ProfitRate { get; set; } //kar oran
        public double VATRate { get; set; }//KDV oranı

        //Bu ve product arasu ilişki her ürünün bir fiyatı var ama bir fiyat birden fazla ürünün olabilir.
        //Burada tek olan ürün ama çok olan Fiyat
        public List<Product> Products { get; set; }
    }
}
