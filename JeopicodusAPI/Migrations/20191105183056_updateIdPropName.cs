using Microsoft.EntityFrameworkCore.Migrations;

namespace JeopicodusAPI.Migrations
{
    public partial class updateIdPropName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MultipleChoiceId",
                table: "MultipleChoice",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FillInTheBlankId",
                table: "FillInTheBlank",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MultipleChoice",
                newName: "MultipleChoiceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FillInTheBlank",
                newName: "FillInTheBlankId");
        }
    }
}
