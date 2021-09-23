using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serialSeasons_serials_SerialID",
                table: "serialSeasons");

            migrationBuilder.DropForeignKey(
                name: "FK_tvShows_tvShowSeries_TvShowSerieID",
                table: "tvShows");

            migrationBuilder.DropIndex(
                name: "IX_tvShows_TvShowSerieID",
                table: "tvShows");

            migrationBuilder.DropIndex(
                name: "IX_serialSeasons_SerialID",
                table: "serialSeasons");

            migrationBuilder.AddColumn<int>(
                name: "TvShowID",
                table: "tvShowSeries",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "tvShowSeasons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "TvShowID",
                table: "tvShowSeasons",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "serialSeasons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "SerialSerialSeason",
                columns: table => new
                {
                    SerialID = table.Column<int>(type: "int", nullable: false),
                    SerialSeasonsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialSerialSeason", x => new { x.SerialID, x.SerialSeasonsID });
                    table.ForeignKey(
                        name: "FK_SerialSerialSeason_serials_SerialID",
                        column: x => x.SerialID,
                        principalTable: "serials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerialSerialSeason_serialSeasons_SerialSeasonsID",
                        column: x => x.SerialSeasonsID,
                        principalTable: "serialSeasons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tvShowSeries_TvShowID",
                table: "tvShowSeries",
                column: "TvShowID");

            migrationBuilder.CreateIndex(
                name: "IX_tvShowSeasons_TvShowID",
                table: "tvShowSeasons",
                column: "TvShowID");

            migrationBuilder.CreateIndex(
                name: "IX_SerialSerialSeason_SerialSeasonsID",
                table: "SerialSerialSeason",
                column: "SerialSeasonsID");

            migrationBuilder.AddForeignKey(
                name: "FK_tvShowSeasons_tvShows_TvShowID",
                table: "tvShowSeasons",
                column: "TvShowID",
                principalTable: "tvShows",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tvShowSeries_tvShows_TvShowID",
                table: "tvShowSeries",
                column: "TvShowID",
                principalTable: "tvShows",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tvShowSeasons_tvShows_TvShowID",
                table: "tvShowSeasons");

            migrationBuilder.DropForeignKey(
                name: "FK_tvShowSeries_tvShows_TvShowID",
                table: "tvShowSeries");

            migrationBuilder.DropTable(
                name: "SerialSerialSeason");

            migrationBuilder.DropIndex(
                name: "IX_tvShowSeries_TvShowID",
                table: "tvShowSeries");

            migrationBuilder.DropIndex(
                name: "IX_tvShowSeasons_TvShowID",
                table: "tvShowSeasons");

            migrationBuilder.DropColumn(
                name: "TvShowID",
                table: "tvShowSeries");

            migrationBuilder.DropColumn(
                name: "TvShowID",
                table: "tvShowSeasons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Year",
                table: "tvShowSeasons",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Year",
                table: "serialSeasons",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tvShows_TvShowSerieID",
                table: "tvShows",
                column: "TvShowSerieID");

            migrationBuilder.CreateIndex(
                name: "IX_serialSeasons_SerialID",
                table: "serialSeasons",
                column: "SerialID");

            migrationBuilder.AddForeignKey(
                name: "FK_serialSeasons_serials_SerialID",
                table: "serialSeasons",
                column: "SerialID",
                principalTable: "serials",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tvShows_tvShowSeries_TvShowSerieID",
                table: "tvShows",
                column: "TvShowSerieID",
                principalTable: "tvShowSeries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
