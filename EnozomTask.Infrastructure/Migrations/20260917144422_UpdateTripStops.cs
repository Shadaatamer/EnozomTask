using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnozomTask.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTripStops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "StationId", "StopOrder" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "StationId", "Time" },
                values: new object[] { 5, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "StationId", "Time" },
                values: new object[] { 5, new TimeSpan(0, 9, 30, 0, 0) });

            migrationBuilder.InsertData(
                table: "TripStops",
                columns: new[] { "Id", "StationId", "StopOrder", "Time", "TripId" },
                values: new object[] { 20, 1, 4, new TimeSpan(0, 9, 0, 0, 0), 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "StationId", "StopOrder" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "StationId", "Time" },
                values: new object[] { 2, new TimeSpan(0, 7, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TripStops",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "StationId", "Time" },
                values: new object[] { 1, new TimeSpan(0, 9, 0, 0, 0) });
        }
    }
}
