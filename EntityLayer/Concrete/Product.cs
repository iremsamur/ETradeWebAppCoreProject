using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        //Main Category ile ilişkili olacak
        [Key]
        public int ProductID { get; set; }
        public string ProductDescription { get; set; }
        public bool ProductStatus { get; set; }
        //Category Ve Product ilişkisi
        [ForeignKey("MainCategory")]
        public int? MainCategoryID { get; set; }
        public MainCategory MainCategory { get; set; }
        //Brand Ve Product Arasındaki ilişki
        [ForeignKey("Brand")]
        public int? BrandID { get; set; }
        public Brand Brand { get; set; }
        //ProductImage Ve Product İlişkisi
       
        public List<ProductImage> ProductImages { get; set; }
        //Productfeature Ve featuredetail arasındaki çoklu ilişki 
        public List<ProductFeatureDetail> ProductFeatureDetails { get; set; }//çoka çok ilişki
                                                                             //ürün ve fiyatı arasındaki ilişki için
        [ForeignKey("ProductPrice")]
        public int ProductPriceID { get; set; }
        //Product ve campaigns ilişkisi
        public ProductPrice ProductPrice { get; set; }
        //Kampanyalarla ürünler ilişkisi
        public Campaigns campaigns { get; set; }
        //taksitlerle rünler ilişkisi 
        public Installments installments { get; set; }
        //Sepet ürün ilişkisi
        public ShoppingCart shoppingCart { get; set; }


        public List<Order> orders { get; set; }




    }
}
