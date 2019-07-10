using Microsoft.EntityFrameworkCore.Migrations;

namespace RestFull.Data.SQL.Migrations
{
    public partial class RestaurantTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantID",
                table: "Tables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_RestaurantID",
                table: "Tables",
                column: "RestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Restaurants_RestaurantID",
                table: "Tables",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Restaurants_RestaurantID",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_RestaurantID",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "RestaurantID",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Restaurants");
        }
    }
}
