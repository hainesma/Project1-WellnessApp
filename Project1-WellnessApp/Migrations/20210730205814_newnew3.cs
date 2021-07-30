using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1_WellnessApp.Migrations
{
    public partial class newnew3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "applicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    ApplicationUserFK = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userProfiles_applicationUsers_ApplicationUserFK",
                        column: x => x.ApplicationUserFK,
                        principalTable: "applicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "foodRegimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodRegimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_foodRegimes_userProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "userProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "philosophySchools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_philosophySchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_philosophySchools_userProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "userProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_foodRegimes_UserProfileId",
                table: "foodRegimes",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_philosophySchools_UserProfileId",
                table: "philosophySchools",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_userProfiles_ApplicationUserFK",
                table: "userProfiles",
                column: "ApplicationUserFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "foodRegimes");

            migrationBuilder.DropTable(
                name: "philosophySchools");

            migrationBuilder.DropTable(
                name: "userProfiles");

            migrationBuilder.DropTable(
                name: "applicationUsers");
        }
    }
}
