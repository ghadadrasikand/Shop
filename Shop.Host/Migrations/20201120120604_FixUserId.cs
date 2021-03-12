using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Host.Migrations
{
    public partial class FixUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProductCategory",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Product",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Category",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Category",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90fd80f1-22fd-41ac-abfb-d7f8ff4c829a",
                column: "ConcurrencyStamp",
                value: "984abafc-e30f-47fb-ae1c-9eedbd296a53");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "caf502dc-060e-4126-98a0-1d556a432167",
                column: "ConcurrencyStamp",
                value: "023db1db-8018-462c-8e6f-3d22965827c0");
        }
    }
}
