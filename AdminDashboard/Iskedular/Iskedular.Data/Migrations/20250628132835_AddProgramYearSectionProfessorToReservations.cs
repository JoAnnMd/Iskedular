using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iskedular.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProgramYearSectionProfessorToReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Professor",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Program",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YearSection",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Professor",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Program",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "YearSection",
                table: "Reservations");
        }
    }
}
