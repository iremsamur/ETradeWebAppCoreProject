using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressDefinitions_Cities_CityID",
                table: "AddressDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDefinitions_Countries_CountryID",
                table: "AddressDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressDefinitions_Districts_DistrictID",
                table: "AddressDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Installments_InstallmentsInstallmentID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InstallmentsInstallmentID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_AddressDefinitions_CityID",
                table: "AddressDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_AddressDefinitions_CountryID",
                table: "AddressDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_AddressDefinitions_DistrictID",
                table: "AddressDefinitions");

            migrationBuilder.DropColumn(
                name: "InstallmentsInstallmentID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "AddressDefinitions");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "AddressDefinitions");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "AddressDefinitions");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AddressDefinitions",
                newName: "AddressDescription");

            migrationBuilder.AddColumn<int>(
                name: "AddressDefinitionID",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InstallmentID",
                table: "Orders",
                column: "InstallmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_AddressDefinitionID",
                table: "Countries",
                column: "AddressDefinitionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_AddressDefinitions_AddressDefinitionID",
                table: "Countries",
                column: "AddressDefinitionID",
                principalTable: "AddressDefinitions",
                principalColumn: "AddressDefinitionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Installments_InstallmentID",
                table: "Orders",
                column: "InstallmentID",
                principalTable: "Installments",
                principalColumn: "InstallmentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AddressDefinitions_AddressDefinitionID",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Installments_InstallmentID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InstallmentID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Countries_AddressDefinitionID",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "AddressDefinitionID",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "AddressDescription",
                table: "AddressDefinitions",
                newName: "Address");

            migrationBuilder.AddColumn<int>(
                name: "InstallmentsInstallmentID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "AddressDefinitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "AddressDefinitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictID",
                table: "AddressDefinitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InstallmentsInstallmentID",
                table: "Orders",
                column: "InstallmentsInstallmentID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDefinitions_Cities_CityID",
                table: "AddressDefinitions",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDefinitions_Countries_CountryID",
                table: "AddressDefinitions",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDefinitions_Districts_DistrictID",
                table: "AddressDefinitions",
                column: "DistrictID",
                principalTable: "Districts",
                principalColumn: "DistrictID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Installments_InstallmentsInstallmentID",
                table: "Orders",
                column: "InstallmentsInstallmentID",
                principalTable: "Installments",
                principalColumn: "InstallmentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
