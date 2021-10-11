using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class _4Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Username",
                value: "wurstfach69");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Username",
                value: "ahman1337");

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 15, 7, 31, 11, 781, DateTimeKind.Local).AddTicks(3840), new DateTime(2021, 10, 8, 7, 31, 11, 766, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 7, 31, 11, 781, DateTimeKind.Local).AddTicks(9850), new DateTime(2021, 10, 8, 7, 31, 11, 781, DateTimeKind.Local).AddTicks(9190) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

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
    }
}
