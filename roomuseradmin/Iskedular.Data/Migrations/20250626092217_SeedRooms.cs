using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Iskedular.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "ComputerCount", "HasAirConditioning", "HasProjector", "HasTv", "HasWhiteboard", "IsComputerLab", "Name" },
                values: new object[,]
                {
                    { 1, 40, null, false, true, false, true, false, "Room 101" },
                    { 2, 40, null, false, true, false, true, false, "Room 102" },
                    { 3, 40, null, false, true, false, true, false, "Room 103" },
                    { 4, 40, null, false, false, true, true, false, "Room 104" },
                    { 5, 40, null, false, false, true, true, false, "Room 105" },
                    { 6, 40, null, false, false, true, true, false, "Room 106" },
                    { 7, 40, null, false, true, false, true, false, "Room 201" },
                    { 8, 40, null, false, true, false, true, false, "Room 202" },
                    { 9, 40, null, false, true, false, true, false, "Room 203" },
                    { 10, 40, null, false, false, true, true, false, "Room 204" },
                    { 11, 40, null, false, false, true, true, false, "Room 205" },
                    { 12, 40, null, false, false, true, true, false, "Room 206" },
                    { 13, 20, 20, true, false, true, true, true, "Computer Laboratory" },
                    { 14, 60, null, true, false, true, true, false, "Audio Visual Room" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

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
        }
    }
}
