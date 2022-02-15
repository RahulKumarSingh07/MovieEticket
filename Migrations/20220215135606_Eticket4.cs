using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieEticket.Migrations
{
    public partial class Eticket4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Moives_Actors_ActorId",
                table: "Actors_Moives");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Moives_Moviess_MovieId",
                table: "Actors_Moives");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Moives",
                newName: "MoviesssId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors_Moives",
                newName: "ActorsssId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Moives_MovieId",
                table: "Actors_Moives",
                newName: "IX_Actors_Moives_MoviesssId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Moives_Actors_ActorsssId",
                table: "Actors_Moives",
                column: "ActorsssId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Moives_Moviess_MoviesssId",
                table: "Actors_Moives",
                column: "MoviesssId",
                principalTable: "Moviess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Moives_Actors_ActorsssId",
                table: "Actors_Moives");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Moives_Moviess_MoviesssId",
                table: "Actors_Moives");

            migrationBuilder.RenameColumn(
                name: "MoviesssId",
                table: "Actors_Moives",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorsssId",
                table: "Actors_Moives",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Moives_MoviesssId",
                table: "Actors_Moives",
                newName: "IX_Actors_Moives_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Moives_Actors_ActorId",
                table: "Actors_Moives",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Moives_Moviess_MovieId",
                table: "Actors_Moives",
                column: "MovieId",
                principalTable: "Moviess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
