using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iskedular.Data.Migrations
{
    /// <inheritdoc />
    public partial class finalfinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProgramSection",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProgramSection",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgramSection",
                table: "Users");
        }
    }
}
