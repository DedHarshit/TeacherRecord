using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeacherRecord.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeacherToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Name", "Salary" },
                values: new object[] { 123, "NOICE", 1234 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 123);
        }
    }
}
