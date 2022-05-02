using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairfieldConnect.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailName",
                table: "Thumbnails",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Thumbnails",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Thumbnails",
                columns: new[] { "ThumbnailID", "ThumbnailName", "Title" },
                values: new object[] { 1, "House", "House" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Thumbnails",
                keyColumn: "ThumbnailID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ThumbnailName",
                table: "Thumbnails");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Thumbnails");
        }
    }
}
