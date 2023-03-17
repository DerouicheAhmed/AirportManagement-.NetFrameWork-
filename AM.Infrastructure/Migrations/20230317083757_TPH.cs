using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TPH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_Passenger_PassengerListPassportNumber",
                table: "MyReservation");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Traveller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passenger",
                table: "Passenger");

            migrationBuilder.RenameTable(
                name: "Passenger",
                newName: "Passengers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Passengers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmploymentDate",
                table: "Passengers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "Passengers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthInformation",
                table: "Passengers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Passengers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Passengers",
                type: "real",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassportNumber");

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
                name: "FK_MyReservation_Passengers_PassengerListPassportNumber",
                table: "MyReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "EmploymentDate",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "HealthInformation",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "Passenger");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passenger",
                table: "Passenger",
                column: "PassportNumber");

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    Function = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Staff_Passenger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    HealthInformation = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Traveller_Passenger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_Passenger_PassengerListPassportNumber",
                table: "MyReservation",
                column: "PassengerListPassportNumber",
                principalTable: "Passenger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
