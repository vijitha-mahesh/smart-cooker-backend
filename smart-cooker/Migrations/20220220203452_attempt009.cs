using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartCooker.Migrations
{
    public partial class attempt009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Product_ProductsId",
                table: "ProductOrder");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "ProductOrder",
                newName: "ProductInOutletId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrder_ProductsId",
                table: "ProductOrder",
                newName: "IX_ProductOrder_ProductInOutletId");

            migrationBuilder.AlterColumn<int>(
                name: "Quentity",
                table: "ProductOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductOrder",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product_Order_Qty",
                table: "ProductOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ProductInOutlet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "ProductInOutlet",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductInOutlet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "ProductInOutlet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Product_ProductId",
                table: "ProductOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_ProductInOutlet_ProductInOutletId",
                table: "ProductOrder",
                column: "ProductInOutletId",
                principalTable: "ProductInOutlet",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Product_ProductId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_ProductInOutlet_ProductInOutletId",
                table: "ProductOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductOrder");

            migrationBuilder.DropColumn(
                name: "Product_Order_Qty",
                table: "ProductOrder");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ProductInOutlet");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductInOutlet");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductInOutlet");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "ProductInOutlet");

            migrationBuilder.RenameColumn(
                name: "ProductInOutletId",
                table: "ProductOrder",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrder_ProductInOutletId",
                table: "ProductOrder",
                newName: "IX_ProductOrder_ProductsId");

            migrationBuilder.AlterColumn<string>(
                name: "Quentity",
                table: "ProductOrder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Product_ProductsId",
                table: "ProductOrder",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id");
        }
    }
}
