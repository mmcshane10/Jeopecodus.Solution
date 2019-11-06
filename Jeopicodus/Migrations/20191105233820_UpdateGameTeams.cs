using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeopicodus.Solution.Migrations
{
    public partial class UpdateGameTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Games_GameId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_GameId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Team");

            migrationBuilder.AddColumn<int>(
                name: "Team1TeamId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team2TeamId",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_Team1TeamId",
                table: "Games",
                column: "Team1TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Team2TeamId",
                table: "Games",
                column: "Team2TeamId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Team1TeamId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Team2TeamId",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Team",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_GameId",
                table: "Team",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Games_GameId",
                table: "Team",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
