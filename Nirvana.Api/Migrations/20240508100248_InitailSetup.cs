using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nirvana.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitailSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelDetails",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockedChildRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelDetails", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoom",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoom", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_HotelRoom_HotelDetails_HotelId",
                        column: x => x.HotelId,
                        principalTable: "HotelDetails",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlackoutDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackoutDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlackoutDates_HotelRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "HotelRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomPriceAndDateRange",
                columns: table => new
                {
                    DateRangeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SingleRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DoubleRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TripleRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdultRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ChildRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SingleEqualDouble = table.Column<bool>(type: "bit", nullable: false),
                    ExceptionCase = table.Column<bool>(type: "bit", nullable: false),
                    NoExtraAdult = table.Column<bool>(type: "bit", nullable: false),
                    NoChild = table.Column<bool>(type: "bit", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPriceAndDateRange", x => x.DateRangeId);
                    table.ForeignKey(
                        name: "FK_RoomPriceAndDateRange_HotelRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "HotelRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlackoutDates_RoomId",
                table: "BlackoutDates",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoom_HotelId",
                table: "HotelRoom",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPriceAndDateRange_RoomId",
                table: "RoomPriceAndDateRange",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlackoutDates");

            migrationBuilder.DropTable(
                name: "RoomPriceAndDateRange");

            migrationBuilder.DropTable(
                name: "HotelRoom");

            migrationBuilder.DropTable(
                name: "HotelDetails");
        }
    }
}
