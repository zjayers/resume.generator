using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class RenameCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Snippets_Company_CompanyId",
                "Snippets");

            migrationBuilder.DropPrimaryKey(
                "PK_Company",
                "Company");

            migrationBuilder.RenameTable(
                "Company",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                "PK_Companies",
                "Companies",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_Snippets_Companies_CompanyId",
                "Snippets",
                "CompanyId",
                "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Snippets_Companies_CompanyId",
                "Snippets");

            migrationBuilder.DropPrimaryKey(
                "PK_Companies",
                "Companies");

            migrationBuilder.RenameTable(
                "Companies",
                newName: "Company");

            migrationBuilder.AddPrimaryKey(
                "PK_Company",
                "Company",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_Snippets_Company_CompanyId",
                "Snippets",
                "CompanyId",
                "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}