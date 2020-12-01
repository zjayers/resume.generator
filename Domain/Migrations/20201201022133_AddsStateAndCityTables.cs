using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class AddsStateAndCityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                "CityId",
                "AspNetUsers",
                "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                "StateId",
                "AspNetUsers",
                "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                "Cities",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Cities", x => x.Id); });

            migrationBuilder.CreateTable(
                "States",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Abbreviation = table.Column<string>("TEXT", nullable: true),
                    Name = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_States", x => x.Id); });

            migrationBuilder.CreateTable(
                "CityState",
                table => new
                {
                    CitiesId = table.Column<Guid>("TEXT", nullable: false),
                    StatesId = table.Column<Guid>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityState", x => new {x.CitiesId, x.StatesId});
                    table.ForeignKey(
                        "FK_CityState_Cities_CitiesId",
                        x => x.CitiesId,
                        "Cities",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_CityState_States_StatesId",
                        x => x.StatesId,
                        "States",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_AspNetUsers_CityId",
                "AspNetUsers",
                "CityId");

            migrationBuilder.CreateIndex(
                "IX_AspNetUsers_StateId",
                "AspNetUsers",
                "StateId");

            migrationBuilder.CreateIndex(
                "IX_CityState_StatesId",
                "CityState",
                "StatesId");

            migrationBuilder.AddForeignKey(
                "FK_AspNetUsers_Cities_CityId",
                "AspNetUsers",
                "CityId",
                "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                "FK_AspNetUsers_States_StateId",
                "AspNetUsers",
                "StateId",
                "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_AspNetUsers_Cities_CityId",
                "AspNetUsers");

            migrationBuilder.DropForeignKey(
                "FK_AspNetUsers_States_StateId",
                "AspNetUsers");

            migrationBuilder.DropTable(
                "CityState");

            migrationBuilder.DropTable(
                "Cities");

            migrationBuilder.DropTable(
                "States");

            migrationBuilder.DropIndex(
                "IX_AspNetUsers_CityId",
                "AspNetUsers");

            migrationBuilder.DropIndex(
                "IX_AspNetUsers_StateId",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "CityId",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "StateId",
                "AspNetUsers");
        }
    }
}