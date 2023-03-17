using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TablePorteuseDeDonnées : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Siege = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    prix = table.Column<double>(type: "float(2)", precision: 2, scale: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.PassengerFK, x.FlightFK });
                    table.ForeignKey(
                        name: "FK_Ticket_MyFlight_FlightFK",
                        column: x => x.FlightFK,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_PassengerFK",
                        column: x => x.PassengerFK,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightFK",
                table: "Ticket",
                column: "FlightFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
