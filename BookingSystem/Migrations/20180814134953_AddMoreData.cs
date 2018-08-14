using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1c30690a-ffea-41b1-91b2-03891deb4601", "478666c0-8122-46dc-b797-4120c0279172" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "478666c0-8122-46dc-b797-4120c0279172", "3d24daf0-047c-4897-bbb5-de1e8d58dde4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1c30690a-ffea-41b1-91b2-03891deb4601", "194be7dc-896e-48df-9407-63fe4769b2d7" });

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "0e2a2d7b-122f-44be-96b8-e8b4ed7269fe", "49e5a3d9-5a2f-4576-a667-0538444d8b0d", "Role", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f00b7d31-0b31-4400-891d-2865a54daf02", 0, null, "2841fa4e-f123-4c03-beb2-50b071ce522b", "terje.engelbertsen@gmail.com", true, false, null, "terje.engelbertsen@gmail.com", "TerjeEngelbertsen", "AQAAAAEAACcQAAAAEJZcpHk/OLWKc1Y9CotyseddLy/7jgZ7rIcLjiySTm7CztinQBLbRNGm+GVIlXT91w==", null, false, null, false, "TerjeEngelbertsen" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "f00b7d31-0b31-4400-891d-2865a54daf02", "0e2a2d7b-122f-44be-96b8-e8b4ed7269fe", "UserRole" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f00b7d31-0b31-4400-891d-2865a54daf02", "0e2a2d7b-122f-44be-96b8-e8b4ed7269fe" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0e2a2d7b-122f-44be-96b8-e8b4ed7269fe", "49e5a3d9-5a2f-4576-a667-0538444d8b0d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f00b7d31-0b31-4400-891d-2865a54daf02", "2841fa4e-f123-4c03-beb2-50b071ce522b" });

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "478666c0-8122-46dc-b797-4120c0279172", "3d24daf0-047c-4897-bbb5-de1e8d58dde4", "Role", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1c30690a-ffea-41b1-91b2-03891deb4601", 0, null, "194be7dc-896e-48df-9407-63fe4769b2d7", "terje.engelbertsen@gmail.com", true, false, null, "terje.engelbertsen@gmail.com", "TerjeEngelbertsen", "AQAAAAEAACcQAAAAEIyERnJuSq4VrUkju4xciHCBXBUW1yAQ7WT9Hm5gGmgfd/ol1mtAyrBwSvgHTecXeg==", "0720766589", true, "dcffc3db-0c3d-4ca8-9c3f-ef8931d9e2a4", false, "TerjeEngelbertsen" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[] { "1c30690a-ffea-41b1-91b2-03891deb4601", "478666c0-8122-46dc-b797-4120c0279172", "UserRole" });
        }
    }
}
