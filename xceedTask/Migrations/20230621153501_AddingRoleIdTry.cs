using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xceedTask.Migrations
{
    /// <inheritdoc />
    public partial class AddingRoleIdTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59a19e46-fa9c-4252-bf3c-a38b38f8f941");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25f4bd0d-8f4d-4929-ae6e-3ee1160226bb", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41b27274-44f7-4034-888f-9d3a7e79f7d7", "AQAAAAIAAYagAAAAEJWoUFOkReEYh8F5LmeCWp2Nci1R7eW9N7djN91ZBwE2Mzmi1Y0XLirObQzJ49Y7jw==", "515065cf-6912-4ce3-bec8-f40463399c64" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25f4bd0d-8f4d-4929-ae6e-3ee1160226bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59a19e46-fa9c-4252-bf3c-a38b38f8f941", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2c496f7-df5e-4807-a363-36d82ae7dd99", "AQAAAAIAAYagAAAAEJmLIaiI4b54Q0lp3ztMHNconzmdeLmbCxGhnvrvXht1IxadjJ7Aeo2TnwYByofDxA==", "2ed03b80-1251-49e9-bfce-27ef6f14e407" });
        }
    }
}
