using Microsoft.EntityFrameworkCore.Migrations;

namespace SupWave.Migrations
{
    public partial class AddUsernameInPlaylistSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Playlist",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Playlist");
        }
    }
}
