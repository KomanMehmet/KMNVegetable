using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KMNVetetable.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Billings_BillingID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BillingID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BillingID",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillingID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BillingID",
                table: "Products",
                column: "BillingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Billings_BillingID",
                table: "Products",
                column: "BillingID",
                principalTable: "Billings",
                principalColumn: "BillingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
