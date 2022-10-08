using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AHLCGApp.EF.Migrations
{
    public partial class CompletedPTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlipText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    AbilityOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ClueThreshold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlipText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    AbilityOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DoomThreshold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enemies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Fight = table.Column<int>(type: "int", nullable: false),
                    Evade = table.Column<int>(type: "int", nullable: false),
                    TraitOne = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TraitTwo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TraitThree = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TraitFour = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SpecialRuleOne = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SpecialRuleTwo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SpecialRuleThree = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FlavorText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AbilityOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityThree = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    Horror = table.Column<int>(type: "int", nullable: false),
                    VictoryPts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enemies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnRevealedText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RevealedText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AbilityTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ConnectionOne = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ConnectionTwo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ConnectionThree = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ConnectionFour = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ConnectionFive = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShroudValue = table.Column<int>(type: "int", nullable: false),
                    ClueValue = table.Column<int>(type: "int", nullable: false),
                    VictoryPoints = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trecheries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TraitOne = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TraitTwo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TraitThree = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TraitFour = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FlavorText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AbilityOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AbilityThree = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trecheries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acts");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Enemies");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Trecheries");
        }
    }
}
