using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class AddHashedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "d29e3e16-9cbc-44da-8144-73eae931e7e4", "ad36fc0f-ed9c-4b8a-930e-ce50ab0904de", "Role", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "665c5fbf-9464-4fcd-bf74-7a10a986ea34", 0, null, "53e7ec00-df2c-47ac-9f88-088a99ab8690", "terje.engelbertsen@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEJYtM48Uvd82kpzYYow+idr1RE1DM8YbcVDD0NumuJj0M5DF8wBdHG5kwGnnuziLsA==", null, false, null, false, "TerjeEngelbertsen" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "665c5fbf-9464-4fcd-bf74-7a10a986ea34", "d29e3e16-9cbc-44da-8144-73eae931e7e4", "UserRole" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "665c5fbf-9464-4fcd-bf74-7a10a986ea34", "d29e3e16-9cbc-44da-8144-73eae931e7e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d29e3e16-9cbc-44da-8144-73eae931e7e4", "ad36fc0f-ed9c-4b8a-930e-ce50ab0904de" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "665c5fbf-9464-4fcd-bf74-7a10a986ea34", "53e7ec00-df2c-47ac-9f88-088a99ab8690" });

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
    }
}
