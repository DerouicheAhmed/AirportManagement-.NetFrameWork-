using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TypeEntitedetenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassengerName",
                table: "Passengers",
                newName: "fullname_FirstName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passengers",
                newName: "fullname_LastName");

            migrationBuilder.AlterColumn<string>(
                name: "fullname_FirstName",
                table: "Passengers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullname_LastName",
                table: "Passengers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullname_FirstName",
                table: "Passengers",
                newName: "PassengerName");

            migrationBuilder.AlterColumn<string>(
                name: "PassengerName",
                table: "Passengers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
