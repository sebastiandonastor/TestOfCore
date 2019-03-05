using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestOfCore.Migrations
{
    public partial class pillerias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OhSorpresaSoyUnPillo",
                table: "Coffes",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        
            migrationBuilder.DropColumn(
                name: "OhSorpresaSoyUnPillo",
                table: "Coffes");
        }
    }
}
