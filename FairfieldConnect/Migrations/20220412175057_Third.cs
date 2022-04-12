using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairfieldConnect.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Address", "Dob", "Email", "Name", "Phone" },
                values: new object[] { 1, "104 S.Franklin Dr., Troy, AL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranminhhien14@gmail.com", "Hien Tran", "7346292088" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);
        }
    }
}
