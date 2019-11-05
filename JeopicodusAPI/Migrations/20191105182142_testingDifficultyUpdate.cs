using Microsoft.EntityFrameworkCore.Migrations;

namespace JeopicodusAPI.Migrations
{
    public partial class testingDifficultyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 43,
                column: "Difficulty",
                value: "Medium");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 43,
                column: "Difficulty",
                value: "Hard");
        }
    }
}
