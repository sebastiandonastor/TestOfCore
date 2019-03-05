using Microsoft.EntityFrameworkCore.Migrations;

namespace TestOfCore.Migrations
{
    public partial class Sukulento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Suculentidad",
                table: "Coffes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Suculentidad",
                table: "Coffes");
        }
    }
}
