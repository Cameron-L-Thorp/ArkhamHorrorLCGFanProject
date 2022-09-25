using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AHLCGApp.EF.Migrations
{
    public partial class BetterStartingTablesListsAreGay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Trait");

            migrationBuilder.AddColumn<string>(
                name: "AbilityOne",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AbilityThree",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AbilityTwo",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraitOne",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TraitThree",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraitTwo",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AbilityOne",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AbilityThree",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AbilityTwo",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraitOne",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TraitThree",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TraitTwo",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbilityOne",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "AbilityThree",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "AbilityTwo",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "TraitOne",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "TraitThree",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "TraitTwo",
                table: "Investigators");

            migrationBuilder.DropColumn(
                name: "AbilityOne",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AbilityThree",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AbilityTwo",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "TraitOne",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "TraitThree",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "TraitTwo",
                table: "Assets");

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    InvestigatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ability_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ability_Investigators_InvestigatorId",
                        column: x => x.InvestigatorId,
                        principalTable: "Investigators",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Trait",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    InvestigatorId = table.Column<int>(type: "int", nullable: true),
                    TraitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trait", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trait_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trait_Investigators_InvestigatorId",
                        column: x => x.InvestigatorId,
                        principalTable: "Investigators",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_AssetId",
                table: "Ability",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_InvestigatorId",
                table: "Ability",
                column: "InvestigatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Trait_AssetId",
                table: "Trait",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Trait_InvestigatorId",
                table: "Trait",
                column: "InvestigatorId");
        }
    }
}
