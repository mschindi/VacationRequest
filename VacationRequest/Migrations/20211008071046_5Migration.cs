using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class _5Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Birthday",
                value: new DateTime(1989, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Birthday",
                value: new DateTime(1989, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 15, 9, 10, 46, 16, DateTimeKind.Local).AddTicks(8540), new DateTime(2021, 10, 8, 9, 10, 46, 1, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 9, 10, 46, 17, DateTimeKind.Local).AddTicks(4490), new DateTime(2021, 10, 8, 9, 10, 46, 17, DateTimeKind.Local).AddTicks(3890) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");

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
    }
}
