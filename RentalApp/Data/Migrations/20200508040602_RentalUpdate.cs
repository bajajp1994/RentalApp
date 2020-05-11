using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalApp.Data.Migrations
{
    public partial class RentalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateReturned",
                table: "Rentals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateReturned",
                table: "Rentals");
        }
    }
}
