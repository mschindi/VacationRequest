using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Avatar",
                value: "https://icon-icons.com/downloadimage.php?id=89781&root=1368/PNG/72/&file=-avatar_89781.png");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Avatar",
                value: "https://icon-icons.com/downloadimage.php?id=89781&root=1368/PNG/72/&file=-avatar_89781.png");

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 7, 17, 25, 56, 660, DateTimeKind.Local).AddTicks(9470), new DateTime(2021, 9, 30, 17, 25, 56, 645, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 10, 17, 25, 56, 661, DateTimeKind.Local).AddTicks(5280), new DateTime(2021, 9, 30, 17, 25, 56, 661, DateTimeKind.Local).AddTicks(4700) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 9, 27, 17, 1, 16, 282, DateTimeKind.Local).AddTicks(640), new DateTime(2021, 9, 20, 17, 1, 16, 266, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 9, 30, 17, 1, 16, 282, DateTimeKind.Local).AddTicks(6750), new DateTime(2021, 9, 20, 17, 1, 16, 282, DateTimeKind.Local).AddTicks(6080) });
        }
    }
}
