using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateShortLink.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urlss",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    LongLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urlss", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urlss");
        }
    }
}
