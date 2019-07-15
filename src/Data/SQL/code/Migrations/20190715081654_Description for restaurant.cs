using Microsoft.EntityFrameworkCore.Migrations;

namespace RestFull.Data.SQL.Migrations
{
    public partial class Descriptionforrestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Restaurants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Restaurants");
        }
    }
}
