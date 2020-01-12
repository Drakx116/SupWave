using Microsoft.EntityFrameworkCore.Migrations;

namespace SupWave.Migrations
{
    public partial class AddSingerInSongSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Singer",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Singer",
                table: "Song");
        }
    }
}
