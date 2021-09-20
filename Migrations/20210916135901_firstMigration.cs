using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "VacationRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 9, 23, 15, 59, 0, 777, DateTimeKind.Local).AddTicks(6700), new DateTime(2021, 9, 16, 15, 59, 0, 762, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 9, 26, 15, 59, 0, 778, DateTimeKind.Local).AddTicks(2630), new DateTime(2021, 9, 16, 15, 59, 0, 778, DateTimeKind.Local).AddTicks(2020) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "VacationRequests",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 9, 23, 11, 42, 6, 52, DateTimeKind.Local).AddTicks(4720), new DateTime(2021, 9, 16, 11, 42, 6, 35, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 9, 26, 11, 42, 6, 53, DateTimeKind.Local).AddTicks(1290), new DateTime(2021, 9, 16, 11, 42, 6, 53, DateTimeKind.Local).AddTicks(540) });
        }
    }
}
