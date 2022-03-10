using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.WebEncoders.Testing;

#nullable disable

namespace SeeSharpers.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title", "Duration", "Movie3d", "BeginTime", "AgeRequirement", "Thumbnail", "Description", "Genre" },
                values: new object[] { 0, "When Harry Met Sally", TimeSpan.Parse("6:12"), false, DateTime.Parse("18 Aug 2022 07:22:16 GMT"), 0, "https://free-images.com/lg/1278/film_rolls_film_rolls.jpg", "some text", "Romantic Comedy" }
            );

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title", "Duration", "Movie3d", "BeginTime", "AgeRequirement", "Thumbnail", "Description", "Genre" },
                values: new object[] { 1, "Harry potter and the deadly hallows", TimeSpan.Parse("02:00"), false, DateTime.Parse("18 Aug 2022 08:22:16 GMT"), 0, "https://media.s-bol.com/qPrGlVlPgJr/550x730.jpg", "As Harry, Ron, and Hermione race against time and evil to destroy the Horcruxes, they uncover the existence of the three most powerful objects in the wizarding world: the Deathly Hallows.", "Romantic Comedy" }
            );

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title", "Duration", "Movie3d", "BeginTime", "AgeRequirement", "Thumbnail", "Description", "Genre" },
                values: new object[] { 2, "James Bond, Spectre", TimeSpan.Parse("02:34"), false, DateTime.Parse("18 Aug 2022 08:23:16 GMT"), 0, "https://www.vprogids.nl/.imaging/mte/gids/textimage-left/dam/cinema/13/79/68/image_13796859.jpeg/jcr:content/image_13796859.jpeg", "A cryptic message from James Bond's past sends him on a trail to uncover the existence of a sinister organisation named SPECTRE. With a new threat dawning, Bond learns the terrible truth about the author of all his pain in his most recent missions.", "Action, Thriller" }
            );

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title", "Duration", "Movie3d", "BeginTime", "AgeRequirement", "Thumbnail", "Description", "Genre" },
                values: new object[] { 3, "The hobbit,", TimeSpan.Parse("01:49"), false, DateTime.Parse("18 Aug 2022 18:23:16 GMT"), 0, "https://media.pathe.nl/nocropthumb/620x955/gfx_content/posters/hobbitbattlefivearmiesposter6b.jpg", "A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it from the dragon Smaug.", "Adventure, Fantasy" }
            );

            migrationBuilder.InsertData(
                table: "Theatres",
                columns: new[] { "Id", "Number", "AmountOfRows", "AmountOfSeats" },
                values: new object[] { 0, 1, 5, 25 }
            );

            migrationBuilder.InsertData(
                table: "Theatres",
                columns: new[] { "Id", "Number", "AmountOfRows", "AmountOfSeats" },
                values: new object[] { 1, 1, 5, 25 }
            );

            migrationBuilder.InsertData(
                table: "Viewings",
                columns: new[] { "Id", "StartDateTime" },
                values: new object[] { 0, DateTime.Parse("18 Aug 2022 18:23:16 GMT") }
            );


            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Email", "Code", "CreatedDate", "Secret"},
                values: new object[] { 1, "test@test.nl", 12345678, DateTime.Parse("18 Aug 2022 18:23:16 GMT"), false }
            );

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Email", "Code", "CreatedDate", "Secret" },
                values: new object[] { 2, "jup@test.nl", 01, DateTime.Parse("18 Aug 2022 18:23:16 GMT"), false }
            );

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Email", "Code", "CreatedDate", "Secret" },
                values: new object[] { 3, "nope@test.nl", 02, DateTime.Parse("18 Aug 2022 18:23:16 GMT"), false }
            );

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Movies WHERE Id = 0", true);
            migrationBuilder.Sql("DELETE FROM Movies WHERE Id = 1", true);
            migrationBuilder.Sql("DELETE FROM Movies WHERE Id = 2", true);
            migrationBuilder.Sql("DELETE FROM Movies WHERE Id = 3", true);

            migrationBuilder.Sql("DELETE FROM Theatres WHERE Id = 0", true);
            migrationBuilder.Sql("DELETE FROM Theatres WHERE Id = 1", true);

            migrationBuilder.Sql("DELETE FROM Viewings WHERE Id = 0", true);
        }
    }
}
