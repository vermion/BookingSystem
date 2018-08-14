using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class ApplicationUserAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7384659c-7d1a-41d6-a91b-85044fcc6589", "a9c0e0ee-1ab3-48da-a185-0d22dc125e6c" });

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10b6ea54-b0a7-4865-b831-fd3538f587ea", 0, null, "06e0bf39-3eaa-4b99-9f4b-8b889d6efb04", "terje.engelbertsen@gmail.com", true, false, null, null, null, null, null, false, null, false, "TerjeEngelbertsen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "10b6ea54-b0a7-4865-b831-fd3538f587ea", "06e0bf39-3eaa-4b99-9f4b-8b889d6efb04" });

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7384659c-7d1a-41d6-a91b-85044fcc6589", 0, "a9c0e0ee-1ab3-48da-a185-0d22dc125e6c", "terje.engelbertsen@gmail.com", true, false, null, null, null, null, null, false, null, false, "TerjeEngelbertsen" });
        }
    }
}
