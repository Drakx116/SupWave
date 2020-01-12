using Microsoft.EntityFrameworkCore.Migrations;

namespace SupWave.Migrations
{
    public partial class AddMediaSongSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Media",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Media",
                table: "Song");
        }
    }
}
