using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlanes_PlaneID",
                table: "MyFlight");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneID",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlanes_PlaneID",
                table: "MyFlight",
                column: "PlaneID",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlanes_PlaneID",
                table: "MyFlight");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneID",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlanes_PlaneID",
                table: "MyFlight",
                column: "PlaneID",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
