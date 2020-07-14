using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuoteMan_b0._1.Data.Migrations
{
    public partial class seed_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 1, "bobsmithh@gmail.com", "Bob", "Smith", "07833373407", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 2, "droctagon@fastmail.net", "Fred", "Octagon", "07833373408", 3 });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "CustomerId", "DateGiven", "DateModified", "Description", "Price", "Status", "VehicleMake", "VehicleModel" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vehicle done got a bit of damage", 350.0m, 0, "Honda", "Civic" },
                    { 2, 1, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vehicle done got a bit of damage", 550.0m, 1, "Honda", "Civic Type-R" },
                    { 3, 2, new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bleheheheheheh", 950.0m, 1, "Toyota", "Landcruiser" },
                    { 4, 2, new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bleheheheheheh", 550.0m, 0, "Toyota", "GT86" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
