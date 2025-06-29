using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Iskedular.Data.Migrations
{
    /// <inheritdoc />
    public partial class basta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    HasProjector = table.Column<bool>(type: "bit", nullable: false),
                    HasWhiteboard = table.Column<bool>(type: "bit", nullable: false),
                    HasTV = table.Column<bool>(type: "bit", nullable: false),
                    HasAirConditioning = table.Column<bool>(type: "bit", nullable: false),
                    HasSoundSystem = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfComputers = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "HasAirConditioning", "HasProjector", "HasSoundSystem", "HasTV", "HasWhiteboard", "Name", "NumberOfComputers" },
                values: new object[,]
                {
                    { 1, 50, "1st Floor", false, true, false, false, true, "Room 101", 0 },
                    { 2, 50, "1st Floor", false, true, false, false, true, "Room 102", 0 },
                    { 3, 50, "1st Floor", false, true, false, false, true, "Room 103", 0 },
                    { 4, 40, "1st Floor", false, false, false, true, true, "Room 104", 0 },
                    { 5, 40, "1st Floor", false, false, false, true, true, "Room 105", 0 },
                    { 6, 40, "1st Floor", false, false, false, true, true, "Room 106", 0 },
                    { 7, 30, "1st Floor", false, true, false, false, true, "Roth #1", 0 },
                    { 8, 30, "1st Floor", false, true, false, false, true, "Roth #2", 0 },
                    { 9, 20, "1st Floor", true, false, false, true, true, "Computer Laboratory", 20 },
                    { 10, 150, "1st Floor", true, false, false, true, true, "(AVR) Audio Visual Room", 0 },
                    { 11, 300, "1st Floor", true, true, true, false, false, "Gymnasium", 0 },
                    { 12, 100, "1st Floor", false, true, true, false, false, "Chapel", 0 },
                    { 13, 50, "2nd Floor", false, true, false, false, true, "Room 201", 0 },
                    { 14, 50, "2nd Floor", false, true, false, false, true, "Room 202", 0 },
                    { 15, 50, "2nd Floor", false, true, false, false, true, "Room 203", 0 },
                    { 16, 40, "2nd Floor", false, false, false, true, true, "Room 204", 0 },
                    { 17, 40, "2nd Floor", false, false, false, true, true, "Room 205", 0 },
                    { 18, 40, "2nd Floor", false, false, false, true, true, "Room 206", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "Email", "FirstName", "LastName", "PasswordHash", "Role" },
                values: new object[] { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin@iskedular.com", "System", "Admin", "$2b$10$QXOBvclWGFmC5DQCWhoY8e.tQuhG2kDYyFiNOsTwLQkkxgKte/wwK", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
