using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class addedAccessFailedAccountAndApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "28a66361-679b-42c5-b248-19cb7e48296c", "0ffafee1-0a2c-458c-aca9-c6d695dcc16a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7384659c-7d1a-41d6-a91b-85044fcc6589", 0, "a9c0e0ee-1ab3-48da-a185-0d22dc125e6c", "terje.engelbertsen@gmail.com", true, false, null, null, null, null, null, false, null, false, "TerjeEngelbertsen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7384659c-7d1a-41d6-a91b-85044fcc6589", "a9c0e0ee-1ab3-48da-a185-0d22dc125e6c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "28a66361-679b-42c5-b248-19cb7e48296c", 0, "0ffafee1-0a2c-458c-aca9-c6d695dcc16a", "terje.engelbertsen@gmail.com", true, false, null, null, null, null, null, false, null, false, "TerjeEngelbertsen" });
        }
    }
}
