using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeeSharpers.Data.Migrations
{
    public partial class FirstModelMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Movie3d = table.Column<bool>(type: "bit", nullable: false),
                    MovieBeginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieAgeRequirement = table.Column<short>(type: "smallint", nullable: false),
                    MovieThumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
