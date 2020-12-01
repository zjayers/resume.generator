using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class SetUpSnippetsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Bullet",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Content = table.Column<string>("TEXT", maxLength: 240, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Bullet", x => x.Id); });

            migrationBuilder.CreateTable(
                "Company",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    LogoUrl = table.Column<string>("TEXT", maxLength: 120, nullable: true),
                    Name = table.Column<string>("TEXT", maxLength: 100, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Company", x => x.Id); });

            migrationBuilder.CreateTable(
                "Snippet",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Description = table.Column<string>("TEXT", nullable: true),
                    StartDate = table.Column<DateTime>("TEXT", nullable: false),
                    EndDate = table.Column<DateTime>("TEXT", nullable: false),
                    IsProfessionalExperience = table.Column<bool>("INTEGER", nullable: false),
                    UserId = table.Column<string>("TEXT", nullable: true),
                    JobTitleId = table.Column<Guid>("TEXT", nullable: true),
                    CompanyId = table.Column<Guid>("TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snippet", x => x.Id);
                    table.ForeignKey(
                        "FK_Snippet_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Snippet_Company_CompanyId",
                        x => x.CompanyId,
                        "Company",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Snippet_JobTitle_JobTitleId",
                        x => x.JobTitleId,
                        "JobTitle",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "BulletSnippet",
                table => new
                {
                    BulletsId = table.Column<Guid>("TEXT", nullable: false),
                    SnippetsId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BulletSnippet", x => new {x.BulletsId, x.SnippetsId});
                    table.ForeignKey(
                        "FK_BulletSnippet_Bullet_BulletsId",
                        x => x.BulletsId,
                        "Bullet",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_BulletSnippet_Snippet_SnippetsId",
                        x => x.SnippetsId,
                        "Snippet",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_BulletSnippet_SnippetsId",
                "BulletSnippet",
                "SnippetsId");

            migrationBuilder.CreateIndex(
                "IX_Snippet_CompanyId",
                "Snippet",
                "CompanyId");

            migrationBuilder.CreateIndex(
                "IX_Snippet_JobTitleId",
                "Snippet",
                "JobTitleId");

            migrationBuilder.CreateIndex(
                "IX_Snippet_UserId",
                "Snippet",
                "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "BulletSnippet");

            migrationBuilder.DropTable(
                "Bullet");

            migrationBuilder.DropTable(
                "Snippet");

            migrationBuilder.DropTable(
                "Company");
        }
    }
}