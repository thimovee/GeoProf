using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectGeoProfs.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VerlofAanvraag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolledigeNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerlofBeginDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerlofEindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerlofReden = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerlofAanvraag", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VerlofAanvraag");
        }
    }
}
