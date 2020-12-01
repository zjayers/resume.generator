using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class RenameJobTitleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_AspNetUsers_JobTitle_JobTitleId",
                "AspNetUsers");

            migrationBuilder.DropForeignKey(
                "FK_Snippets_JobTitle_JobTitleId",
                "Snippets");

            migrationBuilder.DropPrimaryKey(
                "PK_JobTitle",
                "JobTitle");

            migrationBuilder.RenameTable(
                "JobTitle",
                newName: "JobTitles");

            migrationBuilder.AddPrimaryKey(
                "PK_JobTitles",
                "JobTitles",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_AspNetUsers_JobTitles_JobTitleId",
                "AspNetUsers",
                "JobTitleId",
                "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Snippets_JobTitles_JobTitleId",
                "Snippets",
                "JobTitleId",
                "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_AspNetUsers_JobTitles_JobTitleId",
                "AspNetUsers");

            migrationBuilder.DropForeignKey(
                "FK_Snippets_JobTitles_JobTitleId",
                "Snippets");

            migrationBuilder.DropPrimaryKey(
                "PK_JobTitles",
                "JobTitles");

            migrationBuilder.RenameTable(
                "JobTitles",
                newName: "JobTitle");

            migrationBuilder.AddPrimaryKey(
                "PK_JobTitle",
                "JobTitle",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_AspNetUsers_JobTitle_JobTitleId",
                "AspNetUsers",
                "JobTitleId",
                "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Snippets_JobTitle_JobTitleId",
                "Snippets",
                "JobTitleId",
                "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}