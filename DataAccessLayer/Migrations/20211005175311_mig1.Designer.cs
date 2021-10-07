﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211005175311_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.AddressDefinition", b =>
                {
                    b.Property<int>("AddressDefinitionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int>("DistrictID")
                        .HasColumnType("int");

                    b.Property<long>("MobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxAdministration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxNo")
                        .HasColumnType("int");

                    b.Property<string>("TcIdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AddressDefinitionID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("DistrictID");

                    b.HasIndex("UserID");

                    b.ToTable("AddressDefinitions");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Banks", b =>
                {
                    b.Property<int>("BankID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankID");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bill", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressDefinitionID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID1")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("AddressDefinitionID");

                    b.HasIndex("OrderID1");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BrandStatus")
                        .HasColumnType("bit");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Campaigns", b =>
                {
                    b.Property<int>("CampaignsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CampaignsImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignsStatement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountRatio")
                        .HasColumnType("float");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CampaignsID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cargo", b =>
                {
                    b.Property<int>("CargoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyDescreption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoID");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("EntityLayer.Concrete.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.HasIndex("CountryID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EntityLayer.Concrete.District", b =>
                {
                    b.Property<int>("DistrictID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictID");

                    b.HasIndex("CityID");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.InstallmentTable", b =>
                {
                    b.Property<int>("InstallmentTableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstallmentAmount")
                        .HasColumnType("int");

                    b.Property<int>("InstallmentNumber")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("InstallmentTableID");

                    b.ToTable("InstallmentTables");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Installments", b =>
                {
                    b.Property<int>("InstallmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankID")
                        .HasColumnType("int");

                    b.Property<int>("InstallmentTableID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("InstallmentID");

                    b.HasIndex("BankID")
                        .IsUnique();

                    b.HasIndex("InstallmentTableID")
                        .IsUnique();

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("Installments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MainCategory", b =>
                {
                    b.Property<int>("MainCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MainCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MainCategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("MainCategoryID");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargoID")
                        .HasColumnType("int");

                    b.Property<string>("CargoNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstallmentID")
                        .HasColumnType("int");

                    b.Property<int?>("InstallmentsInstallmentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatusID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentOptionsID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProjectedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CargoID");

                    b.HasIndex("InstallmentsInstallmentID");

                    b.HasIndex("OrderStatusID");

                    b.HasIndex("PaymentOptionsID");

                    b.HasIndex("ProductID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("OrderStatusID");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PaymentOptions", b =>
                {
                    b.Property<int>("PaymentOptionsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.HasKey("PaymentOptionsID");

                    b.ToTable("PaymentOptions");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("MainCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductFeatureID")
                        .HasColumnType("int");

                    b.Property<int>("ProductPriceID")
                        .HasColumnType("int");

                    b.Property<bool>("ProductStatus")
                        .HasColumnType("bit");

                    b.HasKey("ProductID");

                    b.HasIndex("BrandID");

                    b.HasIndex("MainCategoryID");

                    b.HasIndex("ProductFeatureID");

                    b.HasIndex("ProductPriceID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductFeature", b =>
                {
                    b.Property<int>("ProductFeatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductFeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductFeatureID");

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductFeatureDetail", b =>
                {
                    b.Property<int>("ProductFeatureDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductFeatureDetailDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductFeatureID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ProductFeatureDetailID");

                    b.HasIndex("ProductFeatureID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductFeatureDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductImage", b =>
                {
                    b.Property<int>("ProductImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatalogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("SlideImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductImageID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductPrice", b =>
                {
                    b.Property<int>("ProductPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ProfitRate")
                        .HasColumnType("float");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<double>("VATRate")
                        .HasColumnType("float");

                    b.HasKey("ProductPriceID");

                    b.ToTable("ProductPrices");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RoleID1")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.HasIndex("RoleID1");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ShoppingCart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("ReservationPeriod")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MainCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("MainCategoryID");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AskSecurity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<int?>("CountryID")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("SecurityQuestionAndAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserMobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserPhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UserRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserTcIdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("DistrictID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AddressDefinition", b =>
                {
                    b.HasOne("EntityLayer.Concrete.City", "City")
                        .WithMany("AddressDefinitions")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Country", "Country")
                        .WithMany("AddressDefinitions")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.District", "District")
                        .WithMany("AddressDefinitions")
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("District");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bill", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AddressDefinition", "AddressDefinition")
                        .WithMany("Bills")
                        .HasForeignKey("AddressDefinitionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressDefinition");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Campaigns", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithOne("campaigns")
                        .HasForeignKey("EntityLayer.Concrete.Campaigns", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.City", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Country", "Country")
                        .WithMany("cities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("EntityLayer.Concrete.District", b =>
                {
                    b.HasOne("EntityLayer.Concrete.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Installments", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Banks", "Banks")
                        .WithOne("Installments")
                        .HasForeignKey("EntityLayer.Concrete.Installments", "BankID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.InstallmentTable", "InstallmentTable")
                        .WithOne("Installments")
                        .HasForeignKey("EntityLayer.Concrete.Installments", "InstallmentTableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithOne("installments")
                        .HasForeignKey("EntityLayer.Concrete.Installments", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banks");

                    b.Navigation("InstallmentTable");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Order", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Cargo", "Cargo")
                        .WithMany("Orders")
                        .HasForeignKey("CargoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Installments", "Installments")
                        .WithMany("Orders")
                        .HasForeignKey("InstallmentsInstallmentID");

                    b.HasOne("EntityLayer.Concrete.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.PaymentOptions", "PaymentOptions")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentOptionsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany("orders")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Installments");

                    b.Navigation("OrderStatus");

                    b.Navigation("PaymentOptions");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.MainCategory", "MainCategory")
                        .WithMany("Products")
                        .HasForeignKey("MainCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.ProductFeature", null)
                        .WithMany("Products")
                        .HasForeignKey("ProductFeatureID");

                    b.HasOne("EntityLayer.Concrete.ProductPrice", "ProductPrice")
                        .WithMany("Products")
                        .HasForeignKey("ProductPriceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("MainCategory");

                    b.Navigation("ProductPrice");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductFeatureDetail", b =>
                {
                    b.HasOne("EntityLayer.Concrete.ProductFeature", "ProductFeature")
                        .WithMany("ProductFeatureDetails")
                        .HasForeignKey("ProductFeatureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", null)
                        .WithMany("ProductFeatureDetails")
                        .HasForeignKey("ProductID");

                    b.Navigation("ProductFeature");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductImage", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Role", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Role", null)
                        .WithMany("Roles")
                        .HasForeignKey("RoleID1");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ShoppingCart", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithOne("shoppingCart")
                        .HasForeignKey("EntityLayer.Concrete.ShoppingCart", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SubCategory", b =>
                {
                    b.HasOne("EntityLayer.Concrete.MainCategory", "MainCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("MainCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.HasOne("EntityLayer.Concrete.City", null)
                        .WithMany("Users")
                        .HasForeignKey("CityID");

                    b.HasOne("EntityLayer.Concrete.Country", null)
                        .WithMany("users")
                        .HasForeignKey("CountryID");

                    b.HasOne("EntityLayer.Concrete.District", null)
                        .WithMany("Users")
                        .HasForeignKey("DistrictID");

                    b.HasOne("EntityLayer.Concrete.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AddressDefinition", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Banks", b =>
                {
                    b.Navigation("Installments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cargo", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.City", b =>
                {
                    b.Navigation("AddressDefinitions");

                    b.Navigation("Districts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Country", b =>
                {
                    b.Navigation("AddressDefinitions");

                    b.Navigation("cities");

                    b.Navigation("users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.District", b =>
                {
                    b.Navigation("AddressDefinitions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.InstallmentTable", b =>
                {
                    b.Navigation("Installments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Installments", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MainCategory", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PaymentOptions", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Navigation("campaigns");

                    b.Navigation("installments");

                    b.Navigation("orders");

                    b.Navigation("ProductFeatureDetails");

                    b.Navigation("ProductImages");

                    b.Navigation("shoppingCart");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductFeature", b =>
                {
                    b.Navigation("ProductFeatureDetails");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ProductPrice", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Role", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
