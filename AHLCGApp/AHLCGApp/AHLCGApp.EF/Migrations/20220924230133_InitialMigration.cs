using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AHLCGApp.EF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ClassType = table.Column<int>(type: "int", nullable: false),
                    IsMultiClass = table.Column<bool>(type: "bit", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Sanity = table.Column<int>(type: "int", nullable: false),
                    Slot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WillVal = table.Column<int>(type: "int", nullable: false),
                    IntVal = table.Column<int>(type: "int", nullable: false),
                    CombatVal = table.Column<int>(type: "int", nullable: false),
                    AgilityVal = table.Column<int>(type: "int", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Investigators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassType = table.Column<int>(type: "int", nullable: false),
                    SecondaryClassType = table.Column<int>(type: "int", nullable: false),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxHealth = table.Column<int>(type: "int", nullable: false),
                    MaxSanity = table.Column<int>(type: "int", nullable: false),
                    Willpower = table.Column<int>(type: "int", nullable: false),
                    Intellect = table.Column<int>(type: "int", nullable: false),
                    Combat = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    ElderSignAbility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeckSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigators", x => x.Id);
                });

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
                    TraitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: true),
                    InvestigatorId = table.Column<int>(type: "int", nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Trait");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Investigators");
        }
    }
}
