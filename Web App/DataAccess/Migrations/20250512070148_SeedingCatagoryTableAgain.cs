using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedingCatagoryTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CatagoryEntity",
                table: "CatagoryEntity");

            migrationBuilder.RenameTable(
                name: "CatagoryEntity",
                newName: "Book_Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Category",
                table: "Book_Category",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Category",
                table: "Book_Category");

            migrationBuilder.RenameTable(
                name: "Book_Category",
                newName: "CatagoryEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatagoryEntity",
                table: "CatagoryEntity",
                column: "Id");
        }
    }
}
