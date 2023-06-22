using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xceedTask.Migrations
{
    /// <inheritdoc />
    public partial class day2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e479108d-2c2f-4cae-b2c9-d06b3ee3d68d");

            migrationBuilder.CreateTable(
                name: "EmployeeLineOfBusinesses",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false),
                    LofId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    LineOFBusinessId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLineOfBusinesses", x => new { x.Eid, x.LofId });
                    table.ForeignKey(
                        name: "FK_EmployeeLineOfBusinesses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeLineOfBusinesses_LineOFBusinesses_LineOFBusinessId",
                        column: x => x.LineOFBusinessId,
                        principalTable: "LineOFBusinesses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f82f6330-69b1-41a3-92fb-db8fed15bbf0", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43f69f4-d225-4569-b85e-8d835fc54e70", "AQAAAAIAAYagAAAAEAw+yPoG2CNVWFEnzVG8cnDNTJXnJd7QglOY6w/SpL32ysD7N8oEZVAVI7BtsP2oIg==", "7d62e0b1-caa0-481b-a416-95565d545c67" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLineOfBusinesses_EmployeeId",
                table: "EmployeeLineOfBusinesses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLineOfBusinesses_LineOFBusinessId",
                table: "EmployeeLineOfBusinesses",
                column: "LineOFBusinessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLineOfBusinesses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f82f6330-69b1-41a3-92fb-db8fed15bbf0");

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
    }
}
