using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Iskedular.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRoomProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerCount",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HasTv",
                table: "Rooms",
                newName: "HasTV");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Content", "ExpiryDate", "IsActive", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "We are excited to launch the new Room Reservation System. Please explore the new features!", null, true, new DateTime(2025, 6, 19, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(5626), "Welcome to Iskedular!" },
                    { 2, "The system will undergo maintenance on [Date] from [Start Time] to [End Time]. Expect temporary downtime.", new DateTime(2025, 7, 1, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6023), true, new DateTime(2025, 6, 24, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6020), "Scheduled Maintenance" },
                    { 3, "This announcement should no longer be visible.", new DateTime(2025, 6, 25, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6149), true, new DateTime(2025, 5, 26, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6097), "Old Announcement (Expired)" },
                    { 4, "We've added a new flexible space. Check Room 301 for details!", null, true, new DateTime(2025, 6, 26, 9, 17, 5, 772, DateTimeKind.Utc).AddTicks(6151), "New Room Added: Collaboration Hub" }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "HasProjector",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.RenameColumn(
                name: "HasTV",
                table: "Rooms",
                newName: "HasTv");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ComputerCount",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "ComputerCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "ComputerCount",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ComputerCount", "HasProjector" },
                values: new object[] { null, false });
        }
    }
}
