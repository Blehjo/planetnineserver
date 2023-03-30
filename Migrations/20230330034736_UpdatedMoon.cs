using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace planetnineserver.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMoon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoonName",
                table: "Moon",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoonName",
                table: "Moon");
        }
    }
}
