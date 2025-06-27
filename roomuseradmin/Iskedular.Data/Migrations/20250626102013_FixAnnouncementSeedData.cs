using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iskedular.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAnnouncementSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 6, 19, 10, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "PublishDate" },
                values: new object[] { new DateTime(2024, 7, 1, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 6, 24, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "PublishDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 59, 59, 0, DateTimeKind.Utc), new DateTime(2024, 5, 1, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 6, 26, 17, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2025, 6, 19, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "PublishDate" },
                values: new object[] { new DateTime(2025, 7, 1, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 6, 24, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "PublishDate" },
                values: new object[] { new DateTime(2025, 6, 25, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6149), new DateTime(2025, 5, 26, 10, 17, 5, 772, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2025, 6, 26, 9, 17, 5, 772, DateTimeKind.Utc).AddTicks(6151));
        }
    }
}
