using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartCooker.Migrations
{
    public partial class attempt_004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OutletId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "applicationUserRolesId",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "identityUserModelsId",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetRoles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "UserWorksInOutlet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    OutletId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWorksInOutlet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWorksInOutlet_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserWorksInOutlet_Outlet_OutletId",
                        column: x => x.OutletId,
                        principalTable: "Outlet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_OutletId",
                table: "Order",
                column: "OutletId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_applicationUserRolesId",
                table: "AspNetUserRoles",
                column: "applicationUserRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_identityUserModelsId",
                table: "AspNetUserRoles",
                column: "identityUserModelsId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserWorksInOutlet_OutletId",
                table: "UserWorksInOutlet",
                column: "OutletId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWorksInOutlet_UserId",
                table: "UserWorksInOutlet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_applicationUserRolesId",
                table: "AspNetUserRoles",
                column: "applicationUserRolesId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_identityUserModelsId",
                table: "AspNetUserRoles",
                column: "identityUserModelsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Outlet_OutletId",
                table: "Order",
                column: "OutletId",
                principalTable: "Outlet",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_applicationUserRolesId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_identityUserModelsId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Outlet_OutletId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "OrderProductOrder");

            migrationBuilder.DropTable(
                name: "OutletProductInOutlet");

            migrationBuilder.DropTable(
                name: "ProductProductInOutlet");

            migrationBuilder.DropTable(
                name: "ProductProductOrder");

            migrationBuilder.DropTable(
                name: "UserWorksInOutlet");

            migrationBuilder.DropIndex(
                name: "IX_Order_OutletId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_applicationUserRolesId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_identityUserModelsId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "OutletId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "applicationUserRolesId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "identityUserModelsId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "AspNetRoles");
        }
    }
}
