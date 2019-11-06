using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeopicodus.Solution.Migrations
{
    public partial class UpdateTeamMemberProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "TeamMembers",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "TeamMembers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
