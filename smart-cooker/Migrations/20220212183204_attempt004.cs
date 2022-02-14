using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartCooker.Migrations
{
    public partial class attempt004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProductOrder");

            migrationBuilder.DropTable(
                name: "OutletProductInOutlet");

            migrationBuilder.DropTable(
                name: "ProductProductInOutlet");

            migrationBuilder.DropTable(
                name: "ProductProductOrder");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "ProductOrder",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductOrder",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutletId",
                table: "ProductInOutlet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductInOutlet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_OrdersId",
                table: "ProductOrder",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductsId",
                table: "ProductOrder",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInOutlet_OutletId",
                table: "ProductInOutlet",
                column: "OutletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInOutlet_ProductId",
                table: "ProductInOutlet",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOutlet_Outlet_OutletId",
                table: "ProductInOutlet",
                column: "OutletId",
                principalTable: "Outlet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOutlet_Product_ProductId",
                table: "ProductInOutlet",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Order_OrdersId",
                table: "ProductOrder",
                column: "OrdersId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Product_ProductsId",
                table: "ProductOrder",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOutlet_Outlet_OutletId",
                table: "ProductInOutlet");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOutlet_Product_ProductId",
                table: "ProductInOutlet");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Order_OrdersId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Product_ProductsId",
                table: "ProductOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductOrder_OrdersId",
                table: "ProductOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductOrder_ProductsId",
                table: "ProductOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductInOutlet_OutletId",
                table: "ProductInOutlet");

            migrationBuilder.DropIndex(
                name: "IX_ProductInOutlet_ProductId",
                table: "ProductInOutlet");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "ProductOrder");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductOrder");

            migrationBuilder.DropColumn(
                name: "OutletId",
                table: "ProductInOutlet");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductInOutlet");

            migrationBuilder.CreateTable(
                name: "OrderProductOrder",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProductOrder", x => new { x.OrdersId, x.ProductOrderId });
                    table.ForeignKey(
                        name: "FK_OrderProductOrder_Order_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProductOrder_ProductOrder_ProductOrderId",
                        column: x => x.ProductOrderId,
                        principalTable: "ProductOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutletProductInOutlet",
                columns: table => new
                {
                    OutletId = table.Column<int>(type: "int", nullable: false),
                    ProductInOutletId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutletProductInOutlet", x => new { x.OutletId, x.ProductInOutletId });
                    table.ForeignKey(
                        name: "FK_OutletProductInOutlet_Outlet_OutletId",
                        column: x => x.OutletId,
                        principalTable: "Outlet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutletProductInOutlet_ProductInOutlet_ProductInOutletId",
                        column: x => x.ProductInOutletId,
                        principalTable: "ProductInOutlet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductInOutlet",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductInOutletId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductInOutlet", x => new { x.ProductId, x.ProductInOutletId });
                    table.ForeignKey(
                        name: "FK_ProductProductInOutlet_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductInOutlet_ProductInOutlet_ProductInOutletId",
                        column: x => x.ProductInOutletId,
                        principalTable: "ProductInOutlet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductOrder",
                columns: table => new
                {
                    ProductOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductOrder", x => new { x.ProductOrderId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductProductOrder_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductOrder_ProductOrder_ProductOrderId",
                        column: x => x.ProductOrderId,
                        principalTable: "ProductOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProductOrder_ProductOrderId",
                table: "OrderProductOrder",
                column: "ProductOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OutletProductInOutlet_ProductInOutletId",
                table: "OutletProductInOutlet",
                column: "ProductInOutletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductInOutlet_ProductInOutletId",
                table: "ProductProductInOutlet",
                column: "ProductInOutletId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductOrder_ProductsId",
                table: "ProductProductOrder",
                column: "ProductsId");
        }
    }
}
