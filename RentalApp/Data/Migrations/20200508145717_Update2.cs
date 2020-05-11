using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalApp.Data.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerIdId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Movies_MovieIdId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "MovieIdId",
                table: "Rentals",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "CustomerIdId",
                table: "Rentals",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_MovieIdId",
                table: "Rentals",
                newName: "IX_Rentals_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_CustomerIdId",
                table: "Rentals",
                newName: "IX_Rentals_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Movies_MovieId",
                table: "Rentals",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Movies_MovieId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Rentals",
                newName: "MovieIdId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Rentals",
                newName: "CustomerIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_MovieId",
                table: "Rentals",
                newName: "IX_Rentals_MovieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                newName: "IX_Rentals_CustomerIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerIdId",
                table: "Rentals",
                column: "CustomerIdId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Movies_MovieIdId",
                table: "Rentals",
                column: "MovieIdId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
