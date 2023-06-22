using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xceedTask.Migrations
{
    /// <inheritdoc />
    public partial class mv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d23e1da5-1e27-4b5a-8cbd-d71bc4b5820b");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dbc93e8-d9cd-402d-aec3-7b913d587995");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d23e1da5-1e27-4b5a-8cbd-d71bc4b5820b", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf86dd57-02f8-4b7f-8ad2-7f1607760443", "AQAAAAIAAYagAAAAEAVfOBItT79vKdBK1yvxUM5Av1efQjEV49FU+ptYK4jpPJeeih+YBbtJJqp5U6ulxQ==", "828b6754-a437-4281-af0a-6d5138376050" });
        }
    }
}
