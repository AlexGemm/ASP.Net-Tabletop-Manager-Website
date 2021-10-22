using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDWebsite.Data.Migrations
{
    public partial class addinguserconnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ApplicationUserId",
                table: "Item",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_AspNetUsers_ApplicationUserId",
                table: "Item",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_AspNetUsers_ApplicationUserId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ApplicationUserId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
