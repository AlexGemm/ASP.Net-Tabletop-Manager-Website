using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDWebsite.Data.Migrations
{
    public partial class statblocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Item",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Charges",
                table: "Item",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Statblock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    AC = table.Column<int>(nullable: false),
                    Shield = table.Column<bool>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Wisdom = table.Column<int>(nullable: false),
                    Charisma = table.Column<int>(nullable: false),
                    SavingThrows = table.Column<string>(maxLength: 200, nullable: true),
                    Resistances = table.Column<string>(maxLength: 200, nullable: true),
                    Immunities = table.Column<string>(maxLength: 200, nullable: true),
                    Vulnerabilities = table.Column<string>(maxLength: 200, nullable: true),
                    ConditionImmunities = table.Column<string>(maxLength: 200, nullable: true),
                    Senses = table.Column<string>(maxLength: 200, nullable: true),
                    Skills = table.Column<string>(maxLength: 200, nullable: true),
                    Languages = table.Column<string>(maxLength: 200, nullable: true),
                    BasicAttacks = table.Column<string>(nullable: true),
                    NonSpellAbilities = table.Column<string>(nullable: true),
                    Passives = table.Column<string>(nullable: true),
                    LegendaryActions = table.Column<string>(nullable: true),
                    SpellCasting = table.Column<string>(nullable: true),
                    ExtraNotes = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statblock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statblock_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Statblock_ApplicationUserId",
                table: "Statblock",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statblock");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Charges",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
