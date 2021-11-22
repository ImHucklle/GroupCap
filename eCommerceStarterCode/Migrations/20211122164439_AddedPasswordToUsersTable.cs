using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class AddedPasswordToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09a6c257-4498-488f-95b3-2d38a41704b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dcc969d-93c4-4cfd-91f9-0190bbce47ae");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5000bff7-e789-4f9e-bb48-8a05d10453f6", "1c821e3c-0e7e-4f23-99c8-999ebb67b9df", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19c82eb8-cf53-4c2b-a51b-0b5e30a8ecc0", "a4860a4e-b03c-44cb-9586-19fc4b3796f3", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19c82eb8-cf53-4c2b-a51b-0b5e30a8ecc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5000bff7-e789-4f9e-bb48-8a05d10453f6");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09a6c257-4498-488f-95b3-2d38a41704b9", "41cdc524-d776-4b76-997e-4cc6f67cec12", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8dcc969d-93c4-4cfd-91f9-0190bbce47ae", "443a70ff-3094-4227-ad63-ea027971bd19", "Admin", "ADMIN" });
        }
    }
}
