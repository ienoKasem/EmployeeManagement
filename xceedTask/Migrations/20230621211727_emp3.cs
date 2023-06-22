using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xceedTask.Migrations
{
    /// <inheritdoc />
    public partial class emp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25f4bd0d-8f4d-4929-ae6e-3ee1160226bb");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aid = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Accounts_Aid",
                        column: x => x.Aid,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineOFBusinesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineOFBusinesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineOFBusinesses_Accounts_Aid",
                        column: x => x.Aid,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLanguages",
                columns: table => new
                {
                    EId = table.Column<int>(type: "int", nullable: false),
                    LId = table.Column<int>(type: "int", nullable: false),
                    Oral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speaking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Listening = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLanguages", x => new { x.EId, x.LId });
                    table.ForeignKey(
                        name: "FK_EmployeeLanguages_Employees_EId",
                        column: x => x.EId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguages_Languages_LId",
                        column: x => x.LId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguages_LId",
                table: "EmployeeLanguages",
                column: "LId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Aid",
                table: "Employees",
                column: "Aid");

            migrationBuilder.CreateIndex(
                name: "IX_LineOFBusinesses_Aid",
                table: "LineOFBusinesses",
                column: "Aid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLanguages");

            migrationBuilder.DropTable(
                name: "LineOFBusinesses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d23e1da5-1e27-4b5a-8cbd-d71bc4b5820b");

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
    }
}
