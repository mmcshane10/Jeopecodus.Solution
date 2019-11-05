using Microsoft.EntityFrameworkCore.Migrations;

namespace JeopicodusAPI.Migrations
{
    public partial class jsDifficultyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 29,
                column: "Difficulty",
                value: "Hard");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FillInTheBlank",
                keyColumn: "FillInTheBlankId",
                keyValue: 29,
                column: "Difficulty",
                value: "Medium");
        }
    }
}
