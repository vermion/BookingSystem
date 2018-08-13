using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class ApplicationUserWithDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9373f515-65e6-458e-a547-8fc83011696a", 0, "c9da67b8-b9a8-41c0-9fe1-18bf3da4395b", "terje.engelbertsen@gmail.com", true, false, null, null, null, null, null, false, null, false, "TerjeEngelbertsen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9373f515-65e6-458e-a547-8fc83011696a", "c9da67b8-b9a8-41c0-9fe1-18bf3da4395b" });
        }
    }
}
