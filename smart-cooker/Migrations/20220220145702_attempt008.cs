using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartCooker.Migrations
{
    public partial class attempt008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quentity",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quentity",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
