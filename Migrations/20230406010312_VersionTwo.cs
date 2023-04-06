using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace planetnineserver.Migrations
{
    /// <inheritdoc />
    public partial class VersionTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "Favorite",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "Comment",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Chats",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ChatId",
                table: "Favorite",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ChatId",
                table: "Comment",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Chats_ChatId",
                table: "Comment",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_Chats_ChatId",
                table: "Favorite",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "ChatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Chats_ChatId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_Chats_ChatId",
                table: "Favorite");

            migrationBuilder.DropIndex(
                name: "IX_Favorite_ChatId",
                table: "Favorite");

            migrationBuilder.DropIndex(
                name: "IX_Comment_ChatId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Favorite");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Chats");
        }
    }
}
