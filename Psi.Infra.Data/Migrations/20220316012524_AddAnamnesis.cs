using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psi.Infra.Data.Migrations
{
    public partial class AddAnamnesis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anamnesis",
                columns: table => new
                {
                    AnamnesisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenantFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anamnesis", x => x.AnamnesisId);
                    table.ForeignKey(
                        name: "FK_Anamnesis_Tenants_TenantFk",
                        column: x => x.TenantFk,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnamnesisTopics",
                columns: table => new
                {
                    AnamnesisTopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    AnamnesisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnamnesisTopics", x => x.AnamnesisTopicId);
                    table.ForeignKey(
                        name: "FK_AnamnesisTopics_Anamnesis_AnamnesisFk",
                        column: x => x.AnamnesisFk,
                        principalTable: "Anamnesis",
                        principalColumn: "AnamnesisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnamnesisFields",
                columns: table => new
                {
                    AnamnesisFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    AnamnesisFieldType = table.Column<int>(type: "int", nullable: false),
                    AnamnesisTopicFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnamnesisFields", x => x.AnamnesisFieldId);
                    table.ForeignKey(
                        name: "FK_AnamnesisFields_AnamnesisTopics_AnamnesisTopicFk",
                        column: x => x.AnamnesisTopicFk,
                        principalTable: "AnamnesisTopics",
                        principalColumn: "AnamnesisTopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anamnesis_TenantFk",
                table: "Anamnesis",
                column: "TenantFk");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesisFields_AnamnesisTopicFk",
                table: "AnamnesisFields",
                column: "AnamnesisTopicFk");

            migrationBuilder.CreateIndex(
                name: "IX_AnamnesisTopics_AnamnesisFk",
                table: "AnamnesisTopics",
                column: "AnamnesisFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnamnesisFields");

            migrationBuilder.DropTable(
                name: "AnamnesisTopics");

            migrationBuilder.DropTable(
                name: "Anamnesis");
        }
    }
}
