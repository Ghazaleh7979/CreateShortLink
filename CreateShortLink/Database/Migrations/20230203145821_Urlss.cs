using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateShortLink.Database.Migrations
{
    /// <inheritdoc />
    public partial class Urlss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Links",
                table: "Links");

            migrationBuilder.RenameTable(
                name: "Links",
                newName: "Urlss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urlss",
                table: "Urlss",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Urlss",
                table: "Urlss");

            migrationBuilder.RenameTable(
                name: "Urlss",
                newName: "Links");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Links",
                table: "Links",
                column: "Id");
        }
    }
}
