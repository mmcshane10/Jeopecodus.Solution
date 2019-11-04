using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeopicodus.Solution.Migrations
{
    public partial class UpdateUserProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Team",
                table: "AspNetUsers",
                newName: "TeamName");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TeamName",
                table: "AspNetUsers",
                newName: "Team");
        }
    }
}
