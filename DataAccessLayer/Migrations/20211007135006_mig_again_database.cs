using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_again_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressDefinitions_Users_UserID",
                table: "AddressDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AddressDefinitions_AddressDefinitionID",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Products_ProductID",
                table: "Campaigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Cities_CityID",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Installments_InstallmentTables_InstallmentTableID",
                table: "Installments");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cargos_CargoID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Installments_InstallmentID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentOptions_PaymentOptionsID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatureDetails_ProductFeatures_ProductFeatureID",
                table: "ProductFeatureDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MainCategories_MainCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductID",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_MainCategories_MainCategoryID",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_ProductID",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Installments_InstallmentTableID",
                table: "Installments");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_ProductID",
                table: "Campaigns");

            migrationBuilder.AlterColumn<int>(
                name: "MainCategoryID",
                table: "SubCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ShoppingCarts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MainCategoryID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ProductImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductFeatureID",
                table: "ProductFeatureDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentOptionsID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InstallmentID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CargoID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InstallmentTableID",
                table: "Installments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Districts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Campaigns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AddressDefinitionID",
                table: "Bills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "AddressDefinitions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductID",
                table: "ShoppingCarts",
                column: "ProductID",
                unique: true,
                filter: "[ProductID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Installments_InstallmentTableID",
                table: "Installments",
                column: "InstallmentTableID",
                unique: true,
                filter: "[InstallmentTableID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_ProductID",
                table: "Campaigns",
                column: "ProductID",
                unique: true,
                filter: "[ProductID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDefinitions_Users_UserID",
                table: "AddressDefinitions",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AddressDefinitions_AddressDefinitionID",
                table: "Bills",
                column: "AddressDefinitionID",
                principalTable: "AddressDefinitions",
                principalColumn: "AddressDefinitionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Products_ProductID",
                table: "Campaigns",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Cities_CityID",
                table: "Districts",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Installments_InstallmentTables_InstallmentTableID",
                table: "Installments",
                column: "InstallmentTableID",
                principalTable: "InstallmentTables",
                principalColumn: "InstallmentTableID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cargos_CargoID",
                table: "Orders",
                column: "CargoID",
                principalTable: "Cargos",
                principalColumn: "CargoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Installments_InstallmentID",
                table: "Orders",
                column: "InstallmentID",
                principalTable: "Installments",
                principalColumn: "InstallmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusID",
                table: "Orders",
                column: "OrderStatusID",
                principalTable: "OrderStatuses",
                principalColumn: "OrderStatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentOptions_PaymentOptionsID",
                table: "Orders",
                column: "PaymentOptionsID",
                principalTable: "PaymentOptions",
                principalColumn: "PaymentOptionsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductID",
                table: "Orders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatureDetails_ProductFeatures_ProductFeatureID",
                table: "ProductFeatureDetails",
                column: "ProductFeatureID",
                principalTable: "ProductFeatures",
                principalColumn: "ProductFeatureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MainCategories_MainCategoryID",
                table: "Products",
                column: "MainCategoryID",
                principalTable: "MainCategories",
                principalColumn: "MainCategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductID",
                table: "ShoppingCarts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_MainCategories_MainCategoryID",
                table: "SubCategories",
                column: "MainCategoryID",
                principalTable: "MainCategories",
                principalColumn: "MainCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressDefinitions_Users_UserID",
                table: "AddressDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AddressDefinitions_AddressDefinitionID",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Products_ProductID",
                table: "Campaigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Cities_CityID",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Installments_InstallmentTables_InstallmentTableID",
                table: "Installments");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cargos_CargoID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Installments_InstallmentID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentOptions_PaymentOptionsID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatureDetails_ProductFeatures_ProductFeatureID",
                table: "ProductFeatureDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MainCategories_MainCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductID",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_MainCategories_MainCategoryID",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_ProductID",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Installments_InstallmentTableID",
                table: "Installments");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_ProductID",
                table: "Campaigns");

            migrationBuilder.AlterColumn<int>(
                name: "MainCategoryID",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MainCategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductFeatureID",
                table: "ProductFeatureDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentOptionsID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstallmentID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CargoID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstallmentTableID",
                table: "Installments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressDefinitionID",
                table: "Bills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "AddressDefinitions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductID",
                table: "ShoppingCarts",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Installments_InstallmentTableID",
                table: "Installments",
                column: "InstallmentTableID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_ProductID",
                table: "Campaigns",
                column: "ProductID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDefinitions_Users_UserID",
                table: "AddressDefinitions",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AddressDefinitions_AddressDefinitionID",
                table: "Bills",
                column: "AddressDefinitionID",
                principalTable: "AddressDefinitions",
                principalColumn: "AddressDefinitionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Products_ProductID",
                table: "Campaigns",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Cities_CityID",
                table: "Districts",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Installments_InstallmentTables_InstallmentTableID",
                table: "Installments",
                column: "InstallmentTableID",
                principalTable: "InstallmentTables",
                principalColumn: "InstallmentTableID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cargos_CargoID",
                table: "Orders",
                column: "CargoID",
                principalTable: "Cargos",
                principalColumn: "CargoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Installments_InstallmentID",
                table: "Orders",
                column: "InstallmentID",
                principalTable: "Installments",
                principalColumn: "InstallmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusID",
                table: "Orders",
                column: "OrderStatusID",
                principalTable: "OrderStatuses",
                principalColumn: "OrderStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentOptions_PaymentOptionsID",
                table: "Orders",
                column: "PaymentOptionsID",
                principalTable: "PaymentOptions",
                principalColumn: "PaymentOptionsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductID",
                table: "Orders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatureDetails_ProductFeatures_ProductFeatureID",
                table: "ProductFeatureDetails",
                column: "ProductFeatureID",
                principalTable: "ProductFeatures",
                principalColumn: "ProductFeatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MainCategories_MainCategoryID",
                table: "Products",
                column: "MainCategoryID",
                principalTable: "MainCategories",
                principalColumn: "MainCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductID",
                table: "ShoppingCarts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_MainCategories_MainCategoryID",
                table: "SubCategories",
                column: "MainCategoryID",
                principalTable: "MainCategories",
                principalColumn: "MainCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
