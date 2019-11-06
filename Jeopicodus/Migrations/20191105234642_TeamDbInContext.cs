using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeopicodus.Solution.Migrations
{
    public partial class TeamDbInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Team_TeamId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Team_Team1TeamId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Team_Team2TeamId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Team1TeamId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Team2TeamId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Team1TeamId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Team2TeamId",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GameId",
                table: "Teams",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Games_GameId",
                table: "Teams",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Teams_TeamId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Games_GameId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_GameId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Teams");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.AddColumn<int>(
                name: "Team1TeamId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team2TeamId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Team1TeamId",
                table: "Games",
                column: "Team1TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Team2TeamId",
                table: "Games",
                column: "Team2TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Team_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Team_Team1TeamId",
                table: "Games",
                column: "Team1TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Team_Team2TeamId",
                table: "Games",
                column: "Team2TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
