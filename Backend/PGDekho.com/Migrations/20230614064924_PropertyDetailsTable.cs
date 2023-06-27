using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PGDekho.com.Migrations
{
    public partial class PropertyDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    One_BHK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Two_BHK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Three_BHK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Four_BHK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Five_BHK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Single_Sharing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Double_Sharing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Triple_Sharing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Four_Sharing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    More_Sharing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deposit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumStay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgreementRequirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.PropertyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyDetails");
        }
    }
}
