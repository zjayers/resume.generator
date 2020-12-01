using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class AddsInitialColumnsToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "FirstName",
                "AspNetUsers",
                "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                "Github",
                "AspNetUsers",
                "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "LastName",
                "AspNetUsers",
                "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                "LinkedIn",
                "AspNetUsers",
                "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "Portfolio",
                "AspNetUsers",
                "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "FirstName",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "Github",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "LastName",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "LinkedIn",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "Portfolio",
                "AspNetUsers");
        }
    }
}