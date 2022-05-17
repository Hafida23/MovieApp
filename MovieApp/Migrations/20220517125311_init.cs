using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    MainActor = table.Column<string>(nullable: true),
                    DateRelease = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateRelease", "Genre", "Length", "MainActor", "Title" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009), "Drama", 3, "Haluk Bilginer", "Winter sleep" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateRelease", "Genre", "Length", "MainActor", "Title" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1961), "Action", 2, "Jean Belmondo", "A Bout De Soufle" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateRelease", "Genre", "Length", "MainActor", "Title" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1953), "Drama", 2, "Michael Caine", "Umbrellas of Cherbourg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
