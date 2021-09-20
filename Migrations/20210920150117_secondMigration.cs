using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
