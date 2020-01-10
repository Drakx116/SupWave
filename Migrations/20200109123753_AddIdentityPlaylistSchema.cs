using Microsoft.EntityFrameworkCore.Migrations;

namespace SupWave.Migrations
{
    public partial class AddIdentityPlaylistSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_AspNetUsers_SupWaveUserId",
                table: "Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Playlist_PlaylistId",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlist",
                table: "Playlist");

            migrationBuilder.RenameTable(
                name: "Song",
                newName: "Songs");

            migrationBuilder.RenameTable(
                name: "Playlist",
                newName: "Playlists");

            migrationBuilder.RenameIndex(
                name: "IX_Song_PlaylistId",
                table: "Songs",
                newName: "IX_Songs_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlist_SupWaveUserId",
                table: "Playlists",
                newName: "IX_Playlists_SupWaveUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_AspNetUsers_SupWaveUserId",
                table: "Playlists",
                column: "SupWaveUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_PlaylistId",
                table: "Songs",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_AspNetUsers_SupWaveUserId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_PlaylistId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "Song");

            migrationBuilder.RenameTable(
                name: "Playlists",
                newName: "Playlist");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_PlaylistId",
                table: "Song",
                newName: "IX_Song_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_SupWaveUserId",
                table: "Playlist",
                newName: "IX_Playlist_SupWaveUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song",
                table: "Song",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlist",
                table: "Playlist",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_AspNetUsers_SupWaveUserId",
                table: "Playlist",
                column: "SupWaveUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Playlist_PlaylistId",
                table: "Song",
                column: "PlaylistId",
                principalTable: "Playlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
