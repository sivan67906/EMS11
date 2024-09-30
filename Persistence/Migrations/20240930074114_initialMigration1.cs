using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblEmployees_EmpContactDetailId",
                table: "tblEmployees");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployees_EmpContactDetailId",
                table: "tblEmployees",
                column: "EmpContactDetailId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblEmployees_EmpContactDetailId",
                table: "tblEmployees");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployees_EmpContactDetailId",
                table: "tblEmployees",
                column: "EmpContactDetailId");
        }
    }
}
