using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class fv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_films_platforms_PlatformID",
                table: "films");

            migrationBuilder.DropIndex(
                name: "IX_films_PlatformID",
                table: "films");

            migrationBuilder.AddColumn<int>(
                name: "FilmID",
                table: "platforms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_platforms_FilmID",
                table: "platforms",
                column: "FilmID");

            migrationBuilder.AddForeignKey(
                name: "FK_platforms_films_FilmID",
                table: "platforms",
                column: "FilmID",
                principalTable: "films",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_platforms_films_FilmID",
                table: "platforms");

            migrationBuilder.DropIndex(
                name: "IX_platforms_FilmID",
                table: "platforms");

            migrationBuilder.DropColumn(
                name: "FilmID",
                table: "platforms");

            migrationBuilder.CreateIndex(
                name: "IX_films_PlatformID",
                table: "films",
                column: "PlatformID");

            migrationBuilder.AddForeignKey(
                name: "FK_films_platforms_PlatformID",
                table: "films",
                column: "PlatformID",
                principalTable: "platforms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
