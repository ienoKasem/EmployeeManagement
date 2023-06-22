using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xceedTask.Migrations
{
    /// <inheritdoc />
    public partial class mv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36733608-0e29-48bc-a96a-cf2cd57b2b96");

            migrationBuilder.AlterColumn<decimal>(
                name: "NationalID",
                table: "Employees",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(24,4)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e479108d-2c2f-4cae-b2c9-d06b3ee3d68d", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65a3fe17-e03f-4589-bdf9-ff450384dcc7", "AQAAAAIAAYagAAAAEDV5WtdF0edvwN++NKUC0aj+UrLBkmjjBXgy6mJHdX02VVq7cCuqHREvOKQhZsLTBg==", "c970bfde-474f-417e-bcf1-600b81298142" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e479108d-2c2f-4cae-b2c9-d06b3ee3d68d");

            migrationBuilder.AlterColumn<decimal>(
                name: "NationalID",
                table: "Employees",
                type: "decimal(24,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36733608-0e29-48bc-a96a-cf2cd57b2b96", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb0c7661-9cc7-4b6c-9f5a-eaa3a5e9b342", "AQAAAAIAAYagAAAAEFdYcZncEsicYTFZRpE61SPwdSknu7gnkz30kmvmiThenwewBtOf5kPjb/flI4+Neg==", "853f4841-67d0-4d0a-bc45-462d4faaa5f9" });
        }
    }
}
