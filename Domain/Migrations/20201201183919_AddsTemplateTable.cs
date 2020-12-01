using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class AddsTemplateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "School",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_School", x => x.Id); });

            migrationBuilder.CreateTable(
                "Templates",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    UserId = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                    table.ForeignKey(
                        "FK_Templates_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Tools",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Tools", x => x.Id); });

            migrationBuilder.CreateTable(
                "DatabaseTemplate",
                table => new
                {
                    DatabasesId = table.Column<Guid>("TEXT", nullable: false),
                    TemplatesId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseTemplate", x => new {x.DatabasesId, x.TemplatesId});
                    table.ForeignKey(
                        "FK_DatabaseTemplate_Databases_DatabasesId",
                        x => x.DatabasesId,
                        "Databases",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_DatabaseTemplate_Templates_TemplatesId",
                        x => x.TemplatesId,
                        "Templates",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "FrameworkTemplate",
                table => new
                {
                    FrameworksId = table.Column<Guid>("TEXT", nullable: false),
                    TemplatesId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkTemplate", x => new {x.FrameworksId, x.TemplatesId});
                    table.ForeignKey(
                        "FK_FrameworkTemplate_Frameworks_FrameworksId",
                        x => x.FrameworksId,
                        "Frameworks",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_FrameworkTemplate_Templates_TemplatesId",
                        x => x.TemplatesId,
                        "Templates",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "LanguageTemplate",
                table => new
                {
                    LanguagesId = table.Column<Guid>("TEXT", nullable: false),
                    TemplatesId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageTemplate", x => new {x.LanguagesId, x.TemplatesId});
                    table.ForeignKey(
                        "FK_LanguageTemplate_Languages_LanguagesId",
                        x => x.LanguagesId,
                        "Languages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_LanguageTemplate_Templates_TemplatesId",
                        x => x.TemplatesId,
                        "Templates",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "SchoolTemplate",
                table => new
                {
                    SchoolsId = table.Column<Guid>("TEXT", nullable: false),
                    TemplatesId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTemplate", x => new {x.SchoolsId, x.TemplatesId});
                    table.ForeignKey(
                        "FK_SchoolTemplate_School_SchoolsId",
                        x => x.SchoolsId,
                        "School",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_SchoolTemplate_Templates_TemplatesId",
                        x => x.TemplatesId,
                        "Templates",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "SnippetTemplate",
                table => new
                {
                    SnippetsId = table.Column<Guid>("TEXT", nullable: false),
                    TemplatesId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnippetTemplate", x => new {x.SnippetsId, x.TemplatesId});
                    table.ForeignKey(
                        "FK_SnippetTemplate_Snippets_SnippetsId",
                        x => x.SnippetsId,
                        "Snippets",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_SnippetTemplate_Templates_TemplatesId",
                        x => x.TemplatesId,
                        "Templates",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "TemplateTool",
                table => new
                {
                    TemplatesId = table.Column<Guid>("TEXT", nullable: false),
                    ToolsId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTool", x => new {x.TemplatesId, x.ToolsId});
                    table.ForeignKey(
                        "FK_TemplateTool_Templates_TemplatesId",
                        x => x.TemplatesId,
                        "Templates",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_TemplateTool_Tools_ToolsId",
                        x => x.ToolsId,
                        "Tools",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_DatabaseTemplate_TemplatesId",
                "DatabaseTemplate",
                "TemplatesId");

            migrationBuilder.CreateIndex(
                "IX_FrameworkTemplate_TemplatesId",
                "FrameworkTemplate",
                "TemplatesId");

            migrationBuilder.CreateIndex(
                "IX_LanguageTemplate_TemplatesId",
                "LanguageTemplate",
                "TemplatesId");

            migrationBuilder.CreateIndex(
                "IX_SchoolTemplate_TemplatesId",
                "SchoolTemplate",
                "TemplatesId");

            migrationBuilder.CreateIndex(
                "IX_SnippetTemplate_TemplatesId",
                "SnippetTemplate",
                "TemplatesId");

            migrationBuilder.CreateIndex(
                "IX_Templates_UserId",
                "Templates",
                "UserId");

            migrationBuilder.CreateIndex(
                "IX_TemplateTool_ToolsId",
                "TemplateTool",
                "ToolsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "DatabaseTemplate");

            migrationBuilder.DropTable(
                "FrameworkTemplate");

            migrationBuilder.DropTable(
                "LanguageTemplate");

            migrationBuilder.DropTable(
                "SchoolTemplate");

            migrationBuilder.DropTable(
                "SnippetTemplate");

            migrationBuilder.DropTable(
                "TemplateTool");

            migrationBuilder.DropTable(
                "School");

            migrationBuilder.DropTable(
                "Templates");

            migrationBuilder.DropTable(
                "Tools");
        }
    }
}