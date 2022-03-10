using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeeSharpers.Data.Migrations
{
    public partial class CreateViewingSeatsTable : Migration
    {
        private readonly string _tableName = "ViewingSeats";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: _tableName, 
                table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewingId = table.Column<int>(type:"int", nullable:false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                }, 
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewingSeats", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ViewingSeats_Viewings_ViewingId", 
                table: _tableName,
                column: "Id",
                principalTable: "Viewings",
                principalColumn: "ViewingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViewingSeats_Viewings_ViewingId",
                table: _tableName);

            migrationBuilder.DropTable(
                name: _tableName);
        }
    }
}
