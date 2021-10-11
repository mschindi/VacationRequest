using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class _6Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "PhoneNumber",
                value: 17661422889L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "PhoneNumber",
                value: 17661423879L);

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 15, 10, 0, 24, 971, DateTimeKind.Local).AddTicks(840), new DateTime(2021, 10, 8, 10, 0, 24, 956, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "VacationEndDate", "VacationStartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 10, 0, 24, 971, DateTimeKind.Local).AddTicks(7170), new DateTime(2021, 10, 8, 10, 0, 24, 971, DateTimeKind.Local).AddTicks(6510) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

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
    }
}
