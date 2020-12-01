using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class RenameSnippetsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_BulletSnippet_Snippet_SnippetsId",
                "BulletSnippet");

            migrationBuilder.DropForeignKey(
                "FK_Snippet_AspNetUsers_UserId",
                "Snippet");

            migrationBuilder.DropForeignKey(
                "FK_Snippet_Company_CompanyId",
                "Snippet");

            migrationBuilder.DropForeignKey(
                "FK_Snippet_JobTitle_JobTitleId",
                "Snippet");

            migrationBuilder.DropPrimaryKey(
                "PK_Snippet",
                "Snippet");

            migrationBuilder.RenameTable(
                "Snippet",
                newName: "Snippets");

            migrationBuilder.RenameIndex(
                "IX_Snippet_UserId",
                table: "Snippets",
                newName: "IX_Snippets_UserId");

            migrationBuilder.RenameIndex(
                "IX_Snippet_JobTitleId",
                table: "Snippets",
                newName: "IX_Snippets_JobTitleId");

            migrationBuilder.RenameIndex(
                "IX_Snippet_CompanyId",
                table: "Snippets",
                newName: "IX_Snippets_CompanyId");

            migrationBuilder.AddPrimaryKey(
                "PK_Snippets",
                "Snippets",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_BulletSnippet_Snippets_SnippetsId",
                "BulletSnippet",
                "SnippetsId",
                "Snippets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                "FK_Snippets_AspNetUsers_UserId",
                "Snippets",
                "UserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Snippets_Company_CompanyId",
                "Snippets",
                "CompanyId",
                "Company",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_BulletSnippet_Snippets_SnippetsId",
                "BulletSnippet");

            migrationBuilder.DropForeignKey(
                "FK_Snippets_AspNetUsers_UserId",
                "Snippets");

            migrationBuilder.DropForeignKey(
                "FK_Snippets_Company_CompanyId",
                "Snippets");

            migrationBuilder.DropForeignKey(
                "FK_Snippets_JobTitle_JobTitleId",
                "Snippets");

            migrationBuilder.DropPrimaryKey(
                "PK_Snippets",
                "Snippets");

            migrationBuilder.RenameTable(
                "Snippets",
                newName: "Snippet");

            migrationBuilder.RenameIndex(
                "IX_Snippets_UserId",
                table: "Snippet",
                newName: "IX_Snippet_UserId");

            migrationBuilder.RenameIndex(
                "IX_Snippets_JobTitleId",
                table: "Snippet",
                newName: "IX_Snippet_JobTitleId");

            migrationBuilder.RenameIndex(
                "IX_Snippets_CompanyId",
                table: "Snippet",
                newName: "IX_Snippet_CompanyId");

            migrationBuilder.AddPrimaryKey(
                "PK_Snippet",
                "Snippet",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_BulletSnippet_Snippet_SnippetsId",
                "BulletSnippet",
                "SnippetsId",
                "Snippet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                "FK_Snippet_AspNetUsers_UserId",
                "Snippet",
                "UserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Snippet_Company_CompanyId",
                "Snippet",
                "CompanyId",
                "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_Snippet_JobTitle_JobTitleId",
                "Snippet",
                "JobTitleId",
                "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}