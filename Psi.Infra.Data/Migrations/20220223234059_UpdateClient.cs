using Microsoft.EntityFrameworkCore.Migrations;

namespace Psi.Infra.Data.Migrations
{
    public partial class UpdateClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChargeType",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtyPackageServices",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ServicePackagePrice",
                table: "Clients",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChargeType",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "QtyPackageServices",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ServicePackagePrice",
                table: "Clients");
        }
    }
}
