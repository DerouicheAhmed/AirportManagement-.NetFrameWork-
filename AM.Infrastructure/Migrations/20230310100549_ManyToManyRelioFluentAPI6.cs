using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelioFluentAPI6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightListFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengerListPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "FlightPassengers");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengerListPassportNumber",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassengers_PassengerListPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengerListPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightListFlightId", "PassengerListPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightListFlightId",
                table: "FlightPassenger",
                column: "FlightListFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengerListPassportNumber",
                table: "FlightPassenger",
                column: "PassengerListPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
