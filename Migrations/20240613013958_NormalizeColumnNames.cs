using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalAssessmentRokov.Migrations
{
    /// <inheritdoc />
    public partial class NormalizeColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "UserAccounts",
                newName: "ROLE");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "UserAccounts",
                newName: "PASSWORD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ROLE",
                table: "UserAccounts",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "PASSWORD",
                table: "UserAccounts",
                newName: "password");
        }
    }
}
