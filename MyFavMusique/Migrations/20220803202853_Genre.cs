using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFavMusique.Migrations
{
    public partial class Genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_Genres_GenreId",
                table: "Music");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Music",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Genres_GenreId",
                table: "Music",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_Genres_GenreId",
                table: "Music");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Music",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Genres_GenreId",
                table: "Music",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
