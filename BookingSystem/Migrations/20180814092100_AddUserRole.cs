using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class AddUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "10b6ea54-b0a7-4865-b831-fd3538f587ea", "06e0bf39-3eaa-4b99-9f4b-8b889d6efb04" });

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "c878486f-cf13-46e8-b62b-56cea5726d07", "a68af948-66d9-426c-9610-fdc8bd457ee7", "Role", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9da7410a-5362-4917-a0ba-d00dc20b10b0", 0, null, "214c2be5-67f9-415f-84ca-23a03da80ca0", "terje.engelbertsen@gmail.com", true, false, null, null, null, "urkurk99!", null, false, null, false, "TerjeEngelbertsen" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "9da7410a-5362-4917-a0ba-d00dc20b10b0", "c878486f-cf13-46e8-b62b-56cea5726d07", "UserRole" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9da7410a-5362-4917-a0ba-d00dc20b10b0", "c878486f-cf13-46e8-b62b-56cea5726d07" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c878486f-cf13-46e8-b62b-56cea5726d07", "a68af948-66d9-426c-9610-fdc8bd457ee7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9da7410a-5362-4917-a0ba-d00dc20b10b0", "214c2be5-67f9-415f-84ca-23a03da80ca0" });

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10b6ea54-b0a7-4865-b831-fd3538f587ea", 0, null, "06e0bf39-3eaa-4b99-9f4b-8b889d6efb04", "terje.engelbertsen@gmail.com", true, false, null, null, null, null, null, false, null, false, "TerjeEngelbertsen" });
        }
    }
}
