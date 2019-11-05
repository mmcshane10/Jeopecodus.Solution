using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeopicodus.Solution.Migrations
{
    public partial class RemoveUserForeignKeyRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Games_GameId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GameReference",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Games_GameId",
                table: "AspNetUsers",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Games_GameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GameReference",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Games_GameId",
                table: "AspNetUsers",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
