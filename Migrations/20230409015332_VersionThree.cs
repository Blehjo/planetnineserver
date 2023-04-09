using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace planetnineserver.Migrations
{
    /// <inheritdoc />
    public partial class VersionThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planet_User_UserId",
                table: "Planet");

            migrationBuilder.DropIndex(
                name: "IX_Planet_UserId",
                table: "Planet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Planet");

            migrationBuilder.CreateTable(
                name: "MoonUser",
                columns: table => new
                {
                    MoonsMoonId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoonUser", x => new { x.MoonsMoonId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_MoonUser_Moon_MoonsMoonId",
                        column: x => x.MoonsMoonId,
                        principalTable: "Moon",
                        principalColumn: "MoonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoonUser_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanetUser",
                columns: table => new
                {
                    PlanetsPlanetId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetUser", x => new { x.PlanetsPlanetId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_PlanetUser_Planet_PlanetsPlanetId",
                        column: x => x.PlanetsPlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanetUser_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoonUser_UsersUserId",
                table: "MoonUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetUser_UsersUserId",
                table: "PlanetUser",
                column: "UsersUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoonUser");

            migrationBuilder.DropTable(
                name: "PlanetUser");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Planet",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Planet_UserId",
                table: "Planet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_User_UserId",
                table: "Planet",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
