using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentVacationDays = table.Column<double>(type: "REAL", nullable: false),
                    TotalVacationDays = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<long>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacationRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    VacationStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VacationEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    AllowedVacation = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacationRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacationRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1L, 3 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2L, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CurrentVacationDays", "Email", "FirstName", "LastName", "TotalVacationDays" },
                values: new object[] { 1L, "Wurststraße 69", 10.0, "wurstfach69@wurstkönig.io", "Peter", "Wurstgesicht", 25.0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CurrentVacationDays", "Email", "FirstName", "LastName", "TotalVacationDays" },
                values: new object[] { 2L, "Ahmedstraße 1337", 1.0, "ahma1337@raus.eu", "Hakan", "Murruk", 25.0 });

            migrationBuilder.InsertData(
                table: "VacationRequests",
                columns: new[] { "Id", "AllowedVacation", "Comment", "Title", "UserId", "VacationEndDate", "VacationStartDate" },
                values: new object[] { 1L, true, "Meine Eier tun weh, ich brauche Urlaub", "Urlaubsantrag für Oktober", 1L, new DateTime(2021, 9, 23, 11, 42, 6, 52, DateTimeKind.Local).AddTicks(4720), new DateTime(2021, 9, 16, 11, 42, 6, 35, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.InsertData(
                table: "VacationRequests",
                columns: new[] { "Id", "AllowedVacation", "Comment", "Title", "UserId", "VacationEndDate", "VacationStartDate" },
                values: new object[] { 2L, false, "Ich will meine Füße massieren lassen", "Urlaubsantrag für November", 2L, new DateTime(2021, 9, 26, 11, 42, 6, 53, DateTimeKind.Local).AddTicks(1290), new DateTime(2021, 9, 16, 11, 42, 6, 53, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequests_UserId",
                table: "VacationRequests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "VacationRequests");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
