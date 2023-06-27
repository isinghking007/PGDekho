using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PGDekho.com.Migrations
{
    public partial class AlterPhotoColumnPropertyDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "PropertyDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "PropertyDetails");
        }
    }
}
