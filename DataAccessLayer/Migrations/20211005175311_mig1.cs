using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankLogo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescreption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargoID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "InstallmentTables",
                columns: table => new
                {
                    InstallmentTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstallmentNumber = table.Column<int>(type: "int", nullable: false),
                    InstallmentAmount = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentTables", x => x.InstallmentTableID);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    MainCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.MainCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    OrderStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.OrderStatusID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    PaymentOptionsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.PaymentOptionsID);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    ProductFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.ProductFeatureID);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    ProductPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasePrice = table.Column<double>(type: "float", nullable: false),
                    ProfitRate = table.Column<double>(type: "float", nullable: false),
                    VATRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.ProductPriceID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Roles_Roles_RoleID1",
                        column: x => x.RoleID1,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryID",
                        column: x => x.MainCategoryID,
                        principalTable: "MainCategories",
                        principalColumn: "MainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatus = table.Column<bool>(type: "bit", nullable: false),
                    MainCategoryID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    ProductPriceID = table.Column<int>(type: "int", nullable: false),
                    ProductFeatureID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MainCategories_MainCategoryID",
                        column: x => x.MainCategoryID,
                        principalTable: "MainCategories",
                        principalColumn: "MainCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductFeatures_ProductFeatureID",
                        column: x => x.ProductFeatureID,
                        principalTable: "ProductFeatures",
                        principalColumn: "ProductFeatureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductPrices_ProductPriceID",
                        column: x => x.ProductPriceID,
                        principalTable: "ProductPrices",
                        principalColumn: "ProductPriceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountRatio = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignsImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignsStatement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignsID);
                    table.ForeignKey(
                        name: "FK_Campaigns_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Installments",
                columns: table => new
                {
                    InstallmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    InstallmentTableID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installments", x => x.InstallmentID);
                    table.ForeignKey(
                        name: "FK_Installments_Banks_BankID",
                        column: x => x.BankID,
                        principalTable: "Banks",
                        principalColumn: "BankID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Installments_InstallmentTables_InstallmentTableID",
                        column: x => x.InstallmentTableID,
                        principalTable: "InstallmentTables",
                        principalColumn: "InstallmentTableID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Installments_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatureDetails",
                columns: table => new
                {
                    ProductFeatureDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFeatureDetailDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductFeatureID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatureDetails", x => x.ProductFeatureDetailID);
                    table.ForeignKey(
                        name: "FK_ProductFeatureDetails_ProductFeatures_ProductFeatureID",
                        column: x => x.ProductFeatureID,
                        principalTable: "ProductFeatures",
                        principalColumn: "ProductFeatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatureDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageID);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationPeriod = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTcIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserMobileNumber = table.Column<long>(type: "bigint", nullable: false),
                    UserPhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AskSecurity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityQuestionAndAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderStatusID = table.Column<int>(type: "int", nullable: false),
                    PaymentOptionsID = table.Column<int>(type: "int", nullable: false),
                    InstallmentID = table.Column<int>(type: "int", nullable: false),
                    InstallmentsInstallmentID = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CargoID = table.Column<int>(type: "int", nullable: false),
                    CargoNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Cargos_CargoID",
                        column: x => x.CargoID,
                        principalTable: "Cargos",
                        principalColumn: "CargoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Installments_InstallmentsInstallmentID",
                        column: x => x.InstallmentsInstallmentID,
                        principalTable: "Installments",
                        principalColumn: "InstallmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusID",
                        column: x => x.OrderStatusID,
                        principalTable: "OrderStatuses",
                        principalColumn: "OrderStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentOptions_PaymentOptionsID",
                        column: x => x.PaymentOptionsID,
                        principalTable: "PaymentOptions",
                        principalColumn: "PaymentOptionsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressDefinitions",
                columns: table => new
                {
                    AddressDefinitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNo = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDefinitions", x => x.AddressDefinitionID);
                    table.ForeignKey(
                        name: "FK_AddressDefinitions_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressDefinitions_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressDefinitions_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressDefinitions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID1 = table.Column<int>(type: "int", nullable: false),
                    AddressDefinitionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Bills_AddressDefinitions_AddressDefinitionID",
                        column: x => x.AddressDefinitionID,
                        principalTable: "AddressDefinitions",
                        principalColumn: "AddressDefinitionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_OrderID1",
                        column: x => x.OrderID1,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDefinitions_CityID",
                table: "AddressDefinitions",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDefinitions_CountryID",
                table: "AddressDefinitions",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDefinitions_DistrictID",
                table: "AddressDefinitions",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDefinitions_UserID",
                table: "AddressDefinitions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AddressDefinitionID",
                table: "Bills",
                column: "AddressDefinitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderID1",
                table: "Bills",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_ProductID",
                table: "Campaigns",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityID",
                table: "Districts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Installments_BankID",
                table: "Installments",
                column: "BankID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Installments_InstallmentTableID",
                table: "Installments",
                column: "InstallmentTableID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Installments_ProductID",
                table: "Installments",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CargoID",
                table: "Orders",
                column: "CargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InstallmentsInstallmentID",
                table: "Orders",
                column: "InstallmentsInstallmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusID",
                table: "Orders",
                column: "OrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentOptionsID",
                table: "Orders",
                column: "PaymentOptionsID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductID",
                table: "Orders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatureDetails_ProductFeatureID",
                table: "ProductFeatureDetails",
                column: "ProductFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatureDetails_ProductID",
                table: "ProductFeatureDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandID",
                table: "Products",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MainCategoryID",
                table: "Products",
                column: "MainCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductFeatureID",
                table: "Products",
                column: "ProductFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductPriceID",
                table: "Products",
                column: "ProductPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleID1",
                table: "Roles",
                column: "RoleID1");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductID",
                table: "ShoppingCarts",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryID",
                table: "SubCategories",
                column: "MainCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityID",
                table: "Users",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryID",
                table: "Users",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DistrictID",
                table: "Users",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "ProductFeatureDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "AddressDefinitions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Installments");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "InstallmentTables");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
