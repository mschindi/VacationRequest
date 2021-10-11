using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class _8Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "JobTitle",
                value: "Enten Züchter");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "JobTitle",
                value: "Gärtner");

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 15, 11, 38, 9, 685, DateTimeKind.Local).AddTicks(2710), new DateTime(2021, 10, 8, 11, 38, 9, 669, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 11, 38, 9, 685, DateTimeKind.Local).AddTicks(9510), new DateTime(2021, 10, 8, 11, 38, 9, 685, DateTimeKind.Local).AddTicks(8880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 15, 11, 8, 3, 971, DateTimeKind.Local).AddTicks(1980), new DateTime(2021, 10, 8, 11, 8, 3, 956, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 11, 8, 3, 971, DateTimeKind.Local).AddTicks(8460), new DateTime(2021, 10, 8, 11, 8, 3, 971, DateTimeKind.Local).AddTicks(7860) });
        }
    }
}
