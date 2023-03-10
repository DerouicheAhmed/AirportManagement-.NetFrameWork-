using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightListFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "MyFlight");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passengers",
                newName: "PassengerName");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_MyPlanePlaneId",
                table: "MyFlight",
                newName: "IX_MyFlight_MyPlanePlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "PassengerName",
                table: "Passengers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFlight",
                table: "MyFlight",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightListFlightId",
                table: "FlightPassenger",
                column: "FlightListFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_MyPlanePlaneId",
                table: "MyFlight",
                column: "MyPlanePlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightListFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_MyPlanePlaneId",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFlight",
                table: "MyFlight");

            migrationBuilder.RenameTable(
                name: "MyFlight",
                newName: "Flights");

            migrationBuilder.RenameColumn(
                name: "PassengerName",
                table: "Passengers",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_MyPlanePlaneId",
                table: "Flights",
                newName: "IX_Flights_MyPlanePlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightListFlightId",
                table: "FlightPassenger",
                column: "FlightListFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights",
                column: "MyPlanePlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
