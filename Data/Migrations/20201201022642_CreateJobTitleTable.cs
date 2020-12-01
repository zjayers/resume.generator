using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Data.Migrations
{
    public partial class CreateJobTitleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "JobTitleId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobTitleId",
                table: "AspNetUsers",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_JobTitle_JobTitleId",
                table: "AspNetUsers",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_JobTitle_JobTitleId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobTitleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "AspNetUsers");
        }
    }
}
