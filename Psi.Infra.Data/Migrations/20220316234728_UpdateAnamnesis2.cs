using Microsoft.EntityFrameworkCore.Migrations;

namespace Psi.Infra.Data.Migrations
{
    public partial class UpdateAnamnesis2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "AnamnesisFields",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "AnamnesisFields");
        }
    }
}
