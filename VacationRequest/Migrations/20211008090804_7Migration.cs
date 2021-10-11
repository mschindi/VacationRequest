using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationRequest.Migrations
{
    public partial class _7Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "PhoneNumber",
                value: "017661422889");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "PhoneNumber",
                value: "017661423879");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

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
    }
}
