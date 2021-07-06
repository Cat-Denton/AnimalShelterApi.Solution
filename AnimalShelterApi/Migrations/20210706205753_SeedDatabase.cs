using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Birthdate", "Gender", "ImageUrl", "Name", "Species" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "imgur.com/hiccupcat", "Hiccup", "Cat" },
                    { 2, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "imgur.com/zipdog", "Zipper", "Dog" },
                    { 3, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "imgur.com/coralcat", "Coraline", "Cat" },
                    { 4, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "imgur.com/windoge", "Winchester", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
