using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace planetnineserver.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtificialIntelligenceId",
                table: "Chats",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChatValue",
                table: "ChatComments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "ArtificialIntelligenceId",
                table: "ChatComments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediaLink",
                table: "ChatComments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ChatComments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArtificialIntelligences",
                columns: table => new
                {
                    ArtificialIntelligenceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtificialIntelligences", x => x.ArtificialIntelligenceId);
                    table.ForeignKey(
                        name: "FK_ArtificialIntelligences_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ArtificialIntelligenceId",
                table: "Chats",
                column: "ArtificialIntelligenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatComments_ArtificialIntelligenceId",
                table: "ChatComments",
                column: "ArtificialIntelligenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtificialIntelligences_UserId",
                table: "ArtificialIntelligences",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatComments_ArtificialIntelligences_ArtificialIntelligenceId",
                table: "ChatComments",
                column: "ArtificialIntelligenceId",
                principalTable: "ArtificialIntelligences",
                principalColumn: "ArtificialIntelligenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_ArtificialIntelligences_ArtificialIntelligenceId",
                table: "Chats",
                column: "ArtificialIntelligenceId",
                principalTable: "ArtificialIntelligences",
                principalColumn: "ArtificialIntelligenceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatComments_ArtificialIntelligences_ArtificialIntelligenceId",
                table: "ChatComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_ArtificialIntelligences_ArtificialIntelligenceId",
                table: "Chats");

            migrationBuilder.DropTable(
                name: "ArtificialIntelligences");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ArtificialIntelligenceId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_ChatComments_ArtificialIntelligenceId",
                table: "ChatComments");

            migrationBuilder.DropColumn(
                name: "ArtificialIntelligenceId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ArtificialIntelligenceId",
                table: "ChatComments");

            migrationBuilder.DropColumn(
                name: "MediaLink",
                table: "ChatComments");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ChatComments");

            migrationBuilder.AlterColumn<string>(
                name: "ChatValue",
                table: "ChatComments",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
