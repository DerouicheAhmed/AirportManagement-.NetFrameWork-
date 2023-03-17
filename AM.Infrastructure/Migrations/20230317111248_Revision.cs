using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Revision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    IdSection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.IdSection);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    PlaneId = table.Column<int>(type: "int", nullable: false),
                    SectionIdSection = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seat_MyPlanes_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "MyPlanes",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seat_Section_SectionIdSection",
                        column: x => x.SectionIdSection,
                        principalTable: "Section",
                        principalColumn: "IdSection",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    SeatFK = table.Column<int>(type: "int", nullable: false),
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    DateReservation = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => new { x.PassengerFK, x.SeatFK });
                    table.ForeignKey(
                        name: "FK_Reservation_Passengers_PassengerFK",
                        column: x => x.PassengerFK,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Seat_SeatFK",
                        column: x => x.SeatFK,
                        principalTable: "Seat",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_SeatFK",
                table: "Reservation",
                column: "SeatFK");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_PlaneId",
                table: "Seat",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SectionIdSection",
                table: "Seat",
                column: "SectionIdSection");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Section");
        }
    }
}
