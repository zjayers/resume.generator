using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class RenameSchoolTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_SchoolTemplate_School_SchoolsId",
                "SchoolTemplate");

            migrationBuilder.DropTable(
                "School");

            migrationBuilder.CreateTable(
                "Schools",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Schools", x => x.Id); });

            migrationBuilder.AddForeignKey(
                "FK_SchoolTemplate_Schools_SchoolsId",
                "SchoolTemplate",
                "SchoolsId",
                "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_SchoolTemplate_Schools_SchoolsId",
                "SchoolTemplate");

            migrationBuilder.DropTable(
                "Schools");

            migrationBuilder.CreateTable(
                "School",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_School", x => x.Id); });

            migrationBuilder.AddForeignKey(
                "FK_SchoolTemplate_School_SchoolsId",
                "SchoolTemplate",
                "SchoolsId",
                "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}