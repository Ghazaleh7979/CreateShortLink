using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateShortLink.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    ShortLinkId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.ShortLinkId);
                });

            migrationBuilder.CreateTable(
                name: "Linkssss",
                columns: table => new
                {
                    Longlinkid = table.Column<Guid>(type: "uuid", nullable: false),
                    LongLink = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linkssss", x => x.Longlinkid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Linkssss");
        }
    }
}
