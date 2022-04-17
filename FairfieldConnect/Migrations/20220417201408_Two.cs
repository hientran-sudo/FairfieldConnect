using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairfieldConnect.Migrations
{
    public partial class Two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "TutoringPosts");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ShopPosts");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "SellPosts");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "SellPosts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "ClubID", "CategoryID", "Desc", "Name", "StudentID" },
                values: new object[] { 1, 3, "Connect Stags", "Fairfield Student Association", 3 });

            migrationBuilder.InsertData(
                table: "SellPosts",
                columns: new[] { "SellPostID", "CategoryID", "Desc", "Location", "Price", "StudentID", "Title" },
                values: new object[] { 1, 4, "Dell Inspiron 2022, intel core i7", "pick up at lower level BCC", 1000.0, 4, "Have a new laptop" });

            migrationBuilder.InsertData(
                table: "ShopPosts",
                columns: new[] { "ShopPostID", "CategoryID", "Desc", "Price", "StudentID", "Title" },
                values: new object[] { 1, 4, "I am looking for an used Macbook", 1000.0, 4, "Look for a macbook" });

            migrationBuilder.InsertData(
                table: "TutoringPosts",
                columns: new[] { "TutoringPostID", "CategoryID", "Desc", "Rate", "StudentID", "Subject", "Title" },
                values: new object[] { 1, 2, "I need a tutor who is free on Monday afternoon", 15.0, 3, "Math", "Look for tutoring" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "ClubID", "Desc", "Hosting", "Location", "Title" },
                values: new object[] { 1, 1, "Opportunity to meet potential employers to expand networking", new DateTime(2022, 5, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "Kelly Center, room 203", "Career Fair 2022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SellPosts",
                keyColumn: "SellPostID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShopPosts",
                keyColumn: "ShopPostID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TutoringPosts",
                keyColumn: "TutoringPostID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubID",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TutoringPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ShopPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "SellPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "SellPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
