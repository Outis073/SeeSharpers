using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeeSharpers.Data.Migrations
{
    public partial class migrationfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ViewingStartDateTime",
                table: "Viewings",
                newName: "StartDateTime");

            migrationBuilder.RenameColumn(
                name: "ViewingId",
                table: "Viewings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TicketTotalPrice",
                table: "Tickets",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "TicketSeat",
                table: "Tickets",
                newName: "Seat");

            migrationBuilder.RenameColumn(
                name: "TicketPopcornArrangement",
                table: "Tickets",
                newName: "PopcornArrangement");

            migrationBuilder.RenameColumn(
                name: "TicketDiscountType",
                table: "Tickets",
                newName: "DiscountType");

            migrationBuilder.RenameColumn(
                name: "TicketCode",
                table: "Tickets",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TheatreNumber",
                table: "Theatres",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "TheatreAmountOfSeats",
                table: "Theatres",
                newName: "AmountOfSeats");

            migrationBuilder.RenameColumn(
                name: "TheatreAmountOfRows",
                table: "Theatres",
                newName: "AmountOfRows");

            migrationBuilder.RenameColumn(
                name: "TheatreId",
                table: "Theatres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderSecret",
                table: "Orders",
                newName: "Secret");

            migrationBuilder.RenameColumn(
                name: "OrderEmail",
                table: "Orders",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "OrderCode",
                table: "Orders",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieTitle",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MovieThumbnail",
                table: "Movies",
                newName: "Thumbnail");

            migrationBuilder.RenameColumn(
                name: "MovieGenre",
                table: "Movies",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "MovieDuration",
                table: "Movies",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "MovieDescription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "MovieBeginTime",
                table: "Movies",
                newName: "BeginTime");

            migrationBuilder.RenameColumn(
                name: "MovieAgeRequirement",
                table: "Movies",
                newName: "AgeRequirement");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Languages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genres",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GenreDescription",
                table: "Genres",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genres",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrinted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OrderId",
                table: "Tickets",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Orders_OrderId",
                table: "Tickets",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Orders_OrderId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_OrderId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "IsPrinted",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "Viewings",
                newName: "ViewingStartDateTime");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Viewings",
                newName: "ViewingId");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Tickets",
                newName: "TicketTotalPrice");

            migrationBuilder.RenameColumn(
                name: "Seat",
                table: "Tickets",
                newName: "TicketSeat");

            migrationBuilder.RenameColumn(
                name: "PopcornArrangement",
                table: "Tickets",
                newName: "TicketPopcornArrangement");

            migrationBuilder.RenameColumn(
                name: "DiscountType",
                table: "Tickets",
                newName: "TicketDiscountType");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Tickets",
                newName: "TicketCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Theatres",
                newName: "TheatreNumber");

            migrationBuilder.RenameColumn(
                name: "AmountOfSeats",
                table: "Theatres",
                newName: "TheatreAmountOfSeats");

            migrationBuilder.RenameColumn(
                name: "AmountOfRows",
                table: "Theatres",
                newName: "TheatreAmountOfRows");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Theatres",
                newName: "TheatreId");

            migrationBuilder.RenameColumn(
                name: "Secret",
                table: "Orders",
                newName: "OrderSecret");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Orders",
                newName: "OrderEmail");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Orders",
                newName: "OrderCode");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "MovieTitle");

            migrationBuilder.RenameColumn(
                name: "Thumbnail",
                table: "Movies",
                newName: "MovieThumbnail");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movies",
                newName: "MovieGenre");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Movies",
                newName: "MovieDuration");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "MovieDescription");

            migrationBuilder.RenameColumn(
                name: "BeginTime",
                table: "Movies",
                newName: "MovieBeginTime");

            migrationBuilder.RenameColumn(
                name: "AgeRequirement",
                table: "Movies",
                newName: "MovieAgeRequirement");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Languages",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Genres",
                newName: "GenreDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "GenreId");
        }
    }
}
