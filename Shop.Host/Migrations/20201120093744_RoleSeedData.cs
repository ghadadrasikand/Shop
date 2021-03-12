using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Host.Migrations
{
    public partial class RoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90fd80f1-22fd-41ac-abfb-d7f8ff4c829a", "ee0842a4-6d85-4a28-a89b-bf16512cf4a2", "ApplicationUser", "APPLICATIONUSER" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "caf502dc-060e-4126-98a0-1d556a432167", "80840ebe-abb5-4ecc-a427-7b6920864a63", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90fd80f1-22fd-41ac-abfb-d7f8ff4c829a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "caf502dc-060e-4126-98a0-1d556a432167");
        }
    }
}
