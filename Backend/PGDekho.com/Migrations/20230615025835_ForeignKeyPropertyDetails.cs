using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PGDekho.com.Migrations
{
    public partial class ForeignKeyPropertyDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PropertyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_UserId",
                table: "PropertyDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_Registers_UserId",
                table: "PropertyDetails",
                column: "UserId",
                principalTable: "Registers",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_Registers_UserId",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_UserId",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PropertyDetails");
        }
    }
}
