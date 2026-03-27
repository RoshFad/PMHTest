using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMHTest.Migrations
{
    /// <inheritdoc />
    public partial class Fin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "/img/fcbfcf72-3d1d-4716-a883-c28340ced39c.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "fcbfcf72-3d1d-4716-a883-c28340ced39c.jpg");
        }
    }
}
