using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWeb.Migrations
{
    public partial class shipcost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Shipping",
                newName: "CostSmall");

            migrationBuilder.AddColumn<float>(
                name: "CostLarge",
                table: "Shipping",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CostMed",
                table: "Shipping",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostLarge",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "CostMed",
                table: "Shipping");

            migrationBuilder.RenameColumn(
                name: "CostSmall",
                table: "Shipping",
                newName: "Cost");
        }
    }
}
