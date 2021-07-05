using Microsoft.EntityFrameworkCore.Migrations;

namespace Klir.TechChallenge.Product.Infrastructure.Migrations
{
    public partial class addedpromodescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PromoDescription",
                table: "ProductPromo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromoDescription",
                table: "ProductPromo");
        }
    }
}
