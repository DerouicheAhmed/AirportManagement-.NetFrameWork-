using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Flightrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlanes_MyPlanePlaneId",
                table: "MyFlight");

            migrationBuilder.RenameColumn(
                name: "MyPlanePlaneId",
                table: "MyFlight",
                newName: "PlaneID");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_MyPlanePlaneId",
                table: "MyFlight",
                newName: "IX_MyFlight_PlaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlanes_PlaneID",
                table: "MyFlight",
                column: "PlaneID",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlanes_PlaneID",
                table: "MyFlight");

            migrationBuilder.RenameColumn(
                name: "PlaneID",
                table: "MyFlight",
                newName: "MyPlanePlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_PlaneID",
                table: "MyFlight",
                newName: "IX_MyFlight_MyPlanePlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlanes_MyPlanePlaneId",
                table: "MyFlight",
                column: "MyPlanePlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
