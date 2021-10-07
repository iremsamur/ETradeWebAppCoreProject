using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Biz bu confire metodu içinde veritabanına bağlantı stringimizi tanımlarız.
            //Tanımladığımız bu connection Stringin türü DbContextOptionsBuilder'dır
            //Yani conection stringimi .Net core da bu şekilde tanımlayabilirim.
            optionsBuilder.UseSqlServer("server=KI\\SQLDEVELOPER;database=ETradeDb3;integrated security=true;");
            //Veritabanı bağlantı stringimi bu şekilde tanımlarım.

        }
        public DbSet<AddressDefinition> AddressDefinitions { get; set; }
        public DbSet<Banks> Banks { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Installments> Installments { get; set; }
        public DbSet<InstallmentTable> InstallmentTables { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PaymentOptions> PaymentOptions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductFeatureDetail> ProductFeatureDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
