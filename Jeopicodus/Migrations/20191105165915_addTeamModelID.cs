using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeopicodus.Solution.Migrations
{
    public partial class addTeamModelID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Games_GameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TeamName1",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "TeamName2",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "AspNetUsers",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_GameId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_TeamId");

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsFirst = table.Column<bool>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Team_GameId",
                table: "Team",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Team_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Team_TeamId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "AspNetUsers",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_TeamId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_GameId");

            migrationBuilder.AddColumn<string>(
                name: "TeamName1",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamName2",
                table: "Games",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Games_GameId",
                table: "AspNetUsers",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
