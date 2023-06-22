using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xceedTask.Migrations
{
    /// <inheritdoc />
    public partial class mv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dbc93e8-d9cd-402d-aec3-7b913d587995");

            migrationBuilder.AlterColumn<decimal>(
                name: "NationalID",
                table: "Employees",
                type: "decimal(24,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36733608-0e29-48bc-a96a-cf2cd57b2b96");

            migrationBuilder.AlterColumn<int>(
                name: "NationalID",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(24,4)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dbc93e8-d9cd-402d-aec3-7b913d587995", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ce19c6-5d24-4221-9567-1447bb4d812b", "AQAAAAIAAYagAAAAEHhNSky0jkJnm1yJ75XtMVTtBAyGfBkzZzY8PJUqHXGFQa1gjyI3bguxnZWWXUOoVw==", "02b74859-c96d-4970-9618-e5e141fbaef9" });
        }
    }
}
