using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Host.Migrations
{
    public partial class AddImagePathToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Product",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90fd80f1-22fd-41ac-abfb-d7f8ff4c829a",
                column: "ConcurrencyStamp",
                value: "543b2ebf-8ddc-4836-9e67-dba0f5af03e2");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "caf502dc-060e-4126-98a0-1d556a432167",
                column: "ConcurrencyStamp",
                value: "6c306101-9e7a-49a3-ab31-97b7e9c43b10");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90fd80f1-22fd-41ac-abfb-d7f8ff4c829a",
                column: "ConcurrencyStamp",
                value: "fd57cc05-b2ce-4e14-850a-3fe0e82b49b0");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "caf502dc-060e-4126-98a0-1d556a432167",
                column: "ConcurrencyStamp",
                value: "a0c6f035-32f6-465b-b349-16facbc98b89");
        }
    }
}
