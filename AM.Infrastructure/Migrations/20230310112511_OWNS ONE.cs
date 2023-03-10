using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OWNSONE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullname_LastName",
                table: "Passengers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullname_FirstName",
                table: "Passengers",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passengers",
                newName: "fullname_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passengers",
                newName: "fullname_FirstName");
        }
    }
}
