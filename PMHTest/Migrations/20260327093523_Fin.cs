using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMHTest.Migrations
{
    /// <inheritdoc />
    public partial class Fin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Name", "PhoneNumber", "PhotoPath" },
                values: new object[,]
                {
                    { 1, 1, "Nikita Prokhorenko", "+79111234567", "img/fcbfcf72-3d1d-4716-a883-c28340ced39c.jpg" },
                    { 2, 1, "Andrey", "89211234567", null },
                    { 3, 2, "Maria Osipova", "89115634569", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
