using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TPH2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Passengers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Passengers");
        }
    }
}
