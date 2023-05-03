using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyPlanes",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneCapacity = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "date", nullable: false),
                    PlaneType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlanes", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TelNumber = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    Function = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true),
                    HealthInformation = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassportNumber);
                });

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
                name: "MyFlight",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Departure = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    FlightDate = table.Column<DateTime>(type: "date", nullable: false),
                    EffectiveArrival = table.Column<DateTime>(type: "date", nullable: false),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    PlaneID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFlight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_MyFlight_MyPlanes_PlaneID",
                        column: x => x.PlaneID,
                        principalTable: "MyPlanes",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.SetNull);
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
                    PlaneFK = table.Column<int>(type: "int", nullable: false),
                    SectionFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seat_MyPlanes_PlaneFK",
                        column: x => x.PlaneFK,
                        principalTable: "MyPlanes",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seat_Section_SectionFK",
                        column: x => x.SectionFK,
                        principalTable: "Section",
                        principalColumn: "IdSection");
                });

            migrationBuilder.CreateTable(
                name: "MyReservation",
                columns: table => new
                {
                    FlightListFlightId = table.Column<int>(type: "int", nullable: false),
                    PassengerListPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyReservation", x => new { x.FlightListFlightId, x.PassengerListPassportNumber });
                    table.ForeignKey(
                        name: "FK_MyReservation_MyFlight_FlightListFlightId",
                        column: x => x.FlightListFlightId,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyReservation_Passengers_PassengerListPassportNumber",
                        column: x => x.PassengerListPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_MyFlight_PlaneID",
                table: "MyFlight",
                column: "PlaneID");

            migrationBuilder.CreateIndex(
                name: "IX_MyReservation_PassengerListPassportNumber",
                table: "MyReservation",
                column: "PassengerListPassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_SeatFK",
                table: "Reservation",
                column: "SeatFK");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_PlaneFK",
                table: "Seat",
                column: "PlaneFK");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SectionFK",
                table: "Seat",
                column: "SectionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightFK",
                table: "Ticket",
                column: "FlightFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyReservation");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "MyFlight");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "MyPlanes");
        }
    }
}
