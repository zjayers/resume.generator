using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class RenameBulletTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_BulletSnippet_Bullet_BulletsId",
                "BulletSnippet");

            migrationBuilder.DropPrimaryKey(
                "PK_Bullet",
                "Bullet");

            migrationBuilder.RenameTable(
                "Bullet",
                newName: "Bullets");

            migrationBuilder.AddPrimaryKey(
                "PK_Bullets",
                "Bullets",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_BulletSnippet_Bullets_BulletsId",
                "BulletSnippet",
                "BulletsId",
                "Bullets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_BulletSnippet_Bullets_BulletsId",
                "BulletSnippet");

            migrationBuilder.DropPrimaryKey(
                "PK_Bullets",
                "Bullets");

            migrationBuilder.RenameTable(
                "Bullets",
                newName: "Bullet");

            migrationBuilder.AddPrimaryKey(
                "PK_Bullet",
                "Bullet",
                "Id");

            migrationBuilder.AddForeignKey(
                "FK_BulletSnippet_Bullet_BulletsId",
                "BulletSnippet",
                "BulletsId",
                "Bullet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}