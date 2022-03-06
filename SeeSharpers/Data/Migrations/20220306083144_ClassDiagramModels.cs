using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeeSharpers.Data.Migrations
{
    public partial class ClassDiagramModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieName",
                table: "Movies",
                newName: "MovieTitle");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCode = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderSecret = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Theatres",
                columns: table => new
                {
                    TheatreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheatreNumber = table.Column<int>(type: "int", nullable: false),
                    TheatreAmountOfRows = table.Column<int>(type: "int", nullable: false),
                    TheatreAmountOfSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theatres", x => x.TheatreId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketSeat = table.Column<int>(type: "int", nullable: false),
                    TicketCode = table.Column<int>(type: "int", nullable: false),
                    TicketDiscountType = table.Column<int>(type: "int", nullable: false),
                    TicketPopcornArrangement = table.Column<bool>(type: "bit", nullable: false),
                    TicketTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });

            migrationBuilder.CreateTable(
                name: "Viewings",
                columns: table => new
                {
                    ViewingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewingStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewings", x => x.ViewingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Theatres");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Viewings");

            migrationBuilder.RenameColumn(
                name: "MovieTitle",
                table: "Movies",
                newName: "MovieName");
        }
    }
}
