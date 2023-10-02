using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoastalVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 16, 16, 35, 138, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 16, 16, 35, 138, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 16, 16, 35, 138, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 16, 16, 35, 138, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 2, 16, 16, 35, 138, DateTimeKind.Local).AddTicks(3637));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 14, 45, 0, 366, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 14, 45, 0, 366, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 14, 45, 0, 366, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 14, 45, 0, 366, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 14, 45, 0, 366, DateTimeKind.Local).AddTicks(4930));
        }
    }
}
