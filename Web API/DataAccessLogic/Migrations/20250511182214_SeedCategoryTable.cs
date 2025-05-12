using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLogic.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book_Category",
                columns: new[] { "Id", "CategoryName", "DisplayOrder" },
                values: new object[] { 1, "Action", 1 });

            migrationBuilder.InsertData(
                table: "Book_Category",
                columns: new[] { "Id", "CategoryName", "DisplayOrder" },
                values: new object[] { 2, "Sci-Fi", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book_Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book_Category",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
