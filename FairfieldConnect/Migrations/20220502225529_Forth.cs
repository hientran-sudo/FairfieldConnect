using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairfieldConnect.Migrations
{
    public partial class Forth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "Thumbnails",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Thumbnails",
                keyColumn: "ThumbnailID",
                keyValue: 1,
                column: "ReviewID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Thumbnails_ReviewID",
                table: "Thumbnails",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Thumbnails_Reviews_ReviewID",
                table: "Thumbnails",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thumbnails_Reviews_ReviewID",
                table: "Thumbnails");

            migrationBuilder.DropIndex(
                name: "IX_Thumbnails_ReviewID",
                table: "Thumbnails");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "Thumbnails");
        }
    }
}
