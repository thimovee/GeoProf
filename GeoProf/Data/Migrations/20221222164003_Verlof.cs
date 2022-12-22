using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoProf.Data.Migrations
{
    public partial class Verlof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VerlofAanvraag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolledigeNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerlofBeginDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerlofEindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerlofReden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geaccepteerd = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerlofAanvraag", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VerlofAanvraag");
        }
    }
}
