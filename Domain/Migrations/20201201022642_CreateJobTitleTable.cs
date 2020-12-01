using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class CreateJobTitleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                "JobTitleId",
                "AspNetUsers",
                "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                "JobTitle",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Title = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_JobTitle", x => x.Id); });

            migrationBuilder.CreateIndex(
                "IX_AspNetUsers_JobTitleId",
                "AspNetUsers",
                "JobTitleId");

            migrationBuilder.AddForeignKey(
                "FK_AspNetUsers_JobTitle_JobTitleId",
                "AspNetUsers",
                "JobTitleId",
                "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_AspNetUsers_JobTitle_JobTitleId",
                "AspNetUsers");

            migrationBuilder.DropTable(
                "JobTitle");

            migrationBuilder.DropIndex(
                "IX_AspNetUsers_JobTitleId",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "JobTitleId",
                "AspNetUsers");
        }
    }
}