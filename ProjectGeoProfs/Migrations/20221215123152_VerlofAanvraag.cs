using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectGeoProfs.Migrations
{
    /// <inheritdoc />
    public partial class VerlofAanvraag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Geaccepteerd",
                table: "VerlofAanvraag",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geaccepteerd",
                table: "VerlofAanvraag");
        }
    }
}
