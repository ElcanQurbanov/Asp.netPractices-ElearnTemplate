using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElearnFrontToBack.Migrations
{
    public partial class AddUpdateEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
