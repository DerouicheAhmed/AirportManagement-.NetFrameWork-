using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class REV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_MyPlanes_PlaneId",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Section_SectionIdSection",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_PlaneId",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "Seat");

            migrationBuilder.RenameColumn(
                name: "SectionIdSection",
                table: "Seat",
                newName: "PlaneFK");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_SectionIdSection",
                table: "Seat",
                newName: "IX_Seat_PlaneFK");

            migrationBuilder.AddColumn<int>(
                name: "SectionFK",
                table: "Seat",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SectionFK",
                table: "Seat",
                column: "SectionFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_MyPlanes_PlaneFK",
                table: "Seat",
                column: "PlaneFK",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Section_SectionFK",
                table: "Seat",
                column: "SectionFK",
                principalTable: "Section",
                principalColumn: "IdSection");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_MyPlanes_PlaneFK",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Section_SectionFK",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_SectionFK",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "SectionFK",
                table: "Seat");

            migrationBuilder.RenameColumn(
                name: "PlaneFK",
                table: "Seat",
                newName: "SectionIdSection");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_PlaneFK",
                table: "Seat",
                newName: "IX_Seat_SectionIdSection");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seat_PlaneId",
                table: "Seat",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_MyPlanes_PlaneId",
                table: "Seat",
                column: "PlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Section_SectionIdSection",
                table: "Seat",
                column: "SectionIdSection",
                principalTable: "Section",
                principalColumn: "IdSection",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
