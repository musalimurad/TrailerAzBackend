using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class sd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "films",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_films_CategoryID",
                table: "films",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_films_categories_CategoryID",
                table: "films",
                column: "CategoryID",
                principalTable: "categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_films_categories_CategoryID",
                table: "films");

            migrationBuilder.DropIndex(
                name: "IX_films_CategoryID",
                table: "films");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "films");
        }
    }
}
