﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace resume.generator.Domain.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "AspNetRoles",
                table => new
                {
                    Id = table.Column<string>("TEXT", nullable: false),
                    Name = table.Column<string>("TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>("TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_AspNetRoles", x => x.Id); });

            migrationBuilder.CreateTable(
                "AspNetUsers",
                table => new
                {
                    Id = table.Column<string>("TEXT", nullable: false),
                    UserName = table.Column<string>("TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>("TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>("TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>("TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>("INTEGER", nullable: false),
                    PasswordHash = table.Column<string>("TEXT", nullable: true),
                    SecurityStamp = table.Column<string>("TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>("TEXT", nullable: true),
                    PhoneNumber = table.Column<string>("TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>("INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>("INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>("TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>("INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>("INTEGER", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_AspNetUsers", x => x.Id); });

            migrationBuilder.CreateTable(
                "DeviceCodes",
                table => new
                {
                    UserCode = table.Column<string>("TEXT", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>("TEXT", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>("TEXT", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>("TEXT", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>("TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>("TEXT", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>("TEXT", nullable: false),
                    Expiration = table.Column<DateTime>("TEXT", nullable: false),
                    Data = table.Column<string>("TEXT", maxLength: 50000, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_DeviceCodes", x => x.UserCode); });

            migrationBuilder.CreateTable(
                "PersistedGrants",
                table => new
                {
                    Key = table.Column<string>("TEXT", maxLength: 200, nullable: false),
                    Type = table.Column<string>("TEXT", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>("TEXT", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>("TEXT", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>("TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>("TEXT", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>("TEXT", nullable: false),
                    Expiration = table.Column<DateTime>("TEXT", nullable: true),
                    ConsumedTime = table.Column<DateTime>("TEXT", nullable: true),
                    Data = table.Column<string>("TEXT", maxLength: 50000, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_PersistedGrants", x => x.Key); });

            migrationBuilder.CreateTable(
                "AspNetRoleClaims",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>("TEXT", nullable: false),
                    ClaimType = table.Column<string>("TEXT", nullable: true),
                    ClaimValue = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        x => x.RoleId,
                        "AspNetRoles",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "AspNetUserClaims",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>("TEXT", nullable: false),
                    ClaimType = table.Column<string>("TEXT", nullable: true),
                    ClaimValue = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_AspNetUserClaims_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "AspNetUserLogins",
                table => new
                {
                    LoginProvider = table.Column<string>("TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>("TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>("TEXT", nullable: true),
                    UserId = table.Column<string>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new {x.LoginProvider, x.ProviderKey});
                    table.ForeignKey(
                        "FK_AspNetUserLogins_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "AspNetUserRoles",
                table => new
                {
                    UserId = table.Column<string>("TEXT", nullable: false),
                    RoleId = table.Column<string>("TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new {x.UserId, x.RoleId});
                    table.ForeignKey(
                        "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        x => x.RoleId,
                        "AspNetRoles",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_AspNetUserRoles_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "AspNetUserTokens",
                table => new
                {
                    UserId = table.Column<string>("TEXT", nullable: false),
                    LoginProvider = table.Column<string>("TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>("TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new {x.UserId, x.LoginProvider, x.Name});
                    table.ForeignKey(
                        "FK_AspNetUserTokens_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_AspNetRoleClaims_RoleId",
                "AspNetRoleClaims",
                "RoleId");

            migrationBuilder.CreateIndex(
                "RoleNameIndex",
                "AspNetRoles",
                "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_AspNetUserClaims_UserId",
                "AspNetUserClaims",
                "UserId");

            migrationBuilder.CreateIndex(
                "IX_AspNetUserLogins_UserId",
                "AspNetUserLogins",
                "UserId");

            migrationBuilder.CreateIndex(
                "IX_AspNetUserRoles_RoleId",
                "AspNetUserRoles",
                "RoleId");

            migrationBuilder.CreateIndex(
                "EmailIndex",
                "AspNetUsers",
                "NormalizedEmail");

            migrationBuilder.CreateIndex(
                "UserNameIndex",
                "AspNetUsers",
                "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_DeviceCodes_DeviceCode",
                "DeviceCodes",
                "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_DeviceCodes_Expiration",
                "DeviceCodes",
                "Expiration");

            migrationBuilder.CreateIndex(
                "IX_PersistedGrants_Expiration",
                "PersistedGrants",
                "Expiration");

            migrationBuilder.CreateIndex(
                "IX_PersistedGrants_SubjectId_ClientId_Type",
                "PersistedGrants",
                new[] {"SubjectId", "ClientId", "Type"});

            migrationBuilder.CreateIndex(
                "IX_PersistedGrants_SubjectId_SessionId_Type",
                "PersistedGrants",
                new[] {"SubjectId", "SessionId", "Type"});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "AspNetRoleClaims");

            migrationBuilder.DropTable(
                "AspNetUserClaims");

            migrationBuilder.DropTable(
                "AspNetUserLogins");

            migrationBuilder.DropTable(
                "AspNetUserRoles");

            migrationBuilder.DropTable(
                "AspNetUserTokens");

            migrationBuilder.DropTable(
                "DeviceCodes");

            migrationBuilder.DropTable(
                "PersistedGrants");

            migrationBuilder.DropTable(
                "AspNetRoles");

            migrationBuilder.DropTable(
                "AspNetUsers");
        }
    }
}