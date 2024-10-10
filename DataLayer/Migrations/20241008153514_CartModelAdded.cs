using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class CartModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CartModelcartID",
                table: "StoreProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoreCart",
                columns: table => new
                {
                    cartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCart", x => x.cartID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_CartModelcartID",
                table: "StoreProducts",
                column: "CartModelcartID");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProducts_StoreCart_CartModelcartID",
                table: "StoreProducts",
                column: "CartModelcartID",
                principalTable: "StoreCart",
                principalColumn: "cartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_StoreCart_CartModelcartID",
                table: "StoreProducts");

            migrationBuilder.DropTable(
                name: "StoreCart");

            migrationBuilder.DropIndex(
                name: "IX_StoreProducts_CartModelcartID",
                table: "StoreProducts");

            migrationBuilder.DropColumn(
                name: "CartModelcartID",
                table: "StoreProducts");
        }
    }
}
