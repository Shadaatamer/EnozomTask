using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnozomTask.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TrainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripNumber);
                    table.ForeignKey(
                        name: "FK_Trips_Trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TripStops",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false),
                    StationId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    StopOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripStops", x => new { x.TripId, x.StationId });
                    table.ForeignKey(
                        name: "FK_TripStops_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripStops_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripNumber",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alexandria" },
                    { 2, "Damnhour" },
                    { 3, "Tanta" },
                    { 4, "Banha" },
                    { 5, "Cairo" }
                });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Talgo" },
                    { 2, "French" },
                    { 3, "Spain" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripNumber", "TrainId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "TripStops",
                columns: new[] { "StationId", "TripId", "StopOrder", "Time" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 7, 0, 0, 0) },
                    { 5, 1, 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1, 2, 1, new TimeSpan(0, 7, 30, 0, 0) },
                    { 3, 2, 2, new TimeSpan(0, 8, 30, 0, 0) },
                    { 4, 2, 3, new TimeSpan(0, 9, 30, 0, 0) },
                    { 5, 2, 4, new TimeSpan(0, 10, 30, 0, 0) },
                    { 1, 3, 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 3, 2, new TimeSpan(0, 10, 15, 0, 0) },
                    { 5, 3, 3, new TimeSpan(0, 11, 30, 0, 0) },
                    { 1, 4, 2, new TimeSpan(0, 7, 0, 0, 0) },
                    { 5, 4, 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { 1, 5, 5, new TimeSpan(0, 7, 30, 0, 0) },
                    { 2, 5, 4, new TimeSpan(0, 7, 30, 0, 0) },
                    { 3, 5, 3, new TimeSpan(0, 8, 30, 0, 0) },
                    { 4, 5, 2, new TimeSpan(0, 9, 30, 0, 0) },
                    { 5, 5, 1, new TimeSpan(0, 10, 30, 0, 0) },
                    { 1, 6, 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 6, 2, new TimeSpan(0, 10, 15, 0, 0) },
                    { 5, 6, 1, new TimeSpan(0, 11, 30, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TrainId",
                table: "Trips",
                column: "TrainId");

            migrationBuilder.CreateIndex(
                name: "IX_TripStops_StationId",
                table: "TripStops",
                column: "StationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripStops");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
