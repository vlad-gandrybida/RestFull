using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestFull.Data.SQL.Migrations
{
    public partial class ChangeEntitiesTableandRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Restaurants_RestaurantID",
                table: "Tables");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "Tables",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tables",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_RestaurantID",
                table: "Tables",
                newName: "IX_Tables_RestaurantId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Restaurants",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantId",
                table: "Tables",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Restaurants_RestaurantId",
                table: "Tables",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Restaurants_RestaurantId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Tables",
                newName: "RestaurantID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tables",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_RestaurantId",
                table: "Tables",
                newName: "IX_Tables_RestaurantID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurants",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantID",
                table: "Tables",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Restaurants_RestaurantID",
                table: "Tables",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
