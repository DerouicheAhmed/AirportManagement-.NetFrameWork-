using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassengers_MyFlight_FlightListFlightId",
                table: "FlightPassengers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassengers_Passengers_PassengerListPassportNumber",
                table: "FlightPassengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassengers",
                table: "FlightPassengers");

            migrationBuilder.RenameTable(
                name: "FlightPassengers",
                newName: "MyReservation");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassengers_PassengerListPassportNumber",
                table: "MyReservation",
                newName: "IX_MyReservation_PassengerListPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation",
                columns: new[] { "FlightListFlightId", "PassengerListPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_MyFlight_FlightListFlightId",
                table: "MyReservation",
                column: "FlightListFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_Passengers_PassengerListPassportNumber",
                table: "MyReservation",
                column: "PassengerListPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_MyFlight_FlightListFlightId",
                table: "MyReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_Passengers_PassengerListPassportNumber",
                table: "MyReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation");

            migrationBuilder.RenameTable(
                name: "MyReservation",
                newName: "FlightPassengers");

            migrationBuilder.RenameIndex(
                name: "IX_MyReservation_PassengerListPassportNumber",
                table: "FlightPassengers",
                newName: "IX_FlightPassengers_PassengerListPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassengers",
                table: "FlightPassengers",
                columns: new[] { "FlightListFlightId", "PassengerListPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassengers_MyFlight_FlightListFlightId",
                table: "FlightPassengers",
                column: "FlightListFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassengers_Passengers_PassengerListPassportNumber",
                table: "FlightPassengers",
                column: "PassengerListPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
