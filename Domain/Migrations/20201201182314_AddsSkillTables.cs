using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class AddsSkillTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Databases",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Abbreviation = table.Column<string>("TEXT", nullable: true),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Databases", x => x.Id); });

            migrationBuilder.CreateTable(
                "Languages",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Abbreviation = table.Column<string>("TEXT", nullable: true),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Languages", x => x.Id); });

            migrationBuilder.CreateTable(
                "DatabaseSnippet",
                table => new
                {
                    DatabasesId = table.Column<Guid>("TEXT", nullable: false),
                    SnippetsId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseSnippet", x => new {x.DatabasesId, x.SnippetsId});
                    table.ForeignKey(
                        "FK_DatabaseSnippet_Databases_DatabasesId",
                        x => x.DatabasesId,
                        "Databases",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_DatabaseSnippet_Snippets_SnippetsId",
                        x => x.SnippetsId,
                        "Snippets",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Frameworks",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", nullable: true),
                    Abbreviation = table.Column<string>("TEXT", nullable: true),
                    LanguageId = table.Column<Guid>("TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frameworks", x => x.Id);
                    table.ForeignKey(
                        "FK_Frameworks_Languages_LanguageId",
                        x => x.LanguageId,
                        "Languages",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "LanguageSnippet",
                table => new
                {
                    LanguagesId = table.Column<Guid>("TEXT", nullable: false),
                    SnippetsId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageSnippet", x => new {x.LanguagesId, x.SnippetsId});
                    table.ForeignKey(
                        "FK_LanguageSnippet_Languages_LanguagesId",
                        x => x.LanguagesId,
                        "Languages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_LanguageSnippet_Snippets_SnippetsId",
                        x => x.SnippetsId,
                        "Snippets",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "FrameworkSnippet",
                table => new
                {
                    FrameworksId = table.Column<Guid>("TEXT", nullable: false),
                    SnippetsId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkSnippet", x => new {x.FrameworksId, x.SnippetsId});
                    table.ForeignKey(
                        "FK_FrameworkSnippet_Frameworks_FrameworksId",
                        x => x.FrameworksId,
                        "Frameworks",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_FrameworkSnippet_Snippets_SnippetsId",
                        x => x.SnippetsId,
                        "Snippets",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_DatabaseSnippet_SnippetsId",
                "DatabaseSnippet",
                "SnippetsId");

            migrationBuilder.CreateIndex(
                "IX_Frameworks_LanguageId",
                "Frameworks",
                "LanguageId");

            migrationBuilder.CreateIndex(
                "IX_FrameworkSnippet_SnippetsId",
                "FrameworkSnippet",
                "SnippetsId");

            migrationBuilder.CreateIndex(
                "IX_LanguageSnippet_SnippetsId",
                "LanguageSnippet",
                "SnippetsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "DatabaseSnippet");

            migrationBuilder.DropTable(
                "FrameworkSnippet");

            migrationBuilder.DropTable(
                "LanguageSnippet");

            migrationBuilder.DropTable(
                "Databases");

            migrationBuilder.DropTable(
                "Frameworks");

            migrationBuilder.DropTable(
                "Languages");
        }
    }
}