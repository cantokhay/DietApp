using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class mg02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AppUser_AppUserID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AppUserID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "AppUserProduct",
                columns: table => new
                {
                    ProductsID = table.Column<int>(type: "integer", nullable: false),
                    UsersID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserProduct", x => new { x.ProductsID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_AppUserProduct_AppUser_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AppUser",
                        principalColumn: "AppUserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserProduct_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserProduct_UsersID",
                table: "AppUserProduct",
                column: "UsersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserProduct");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppUserID",
                table: "Products",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AppUser_AppUserID",
                table: "Products",
                column: "AppUserID",
                principalTable: "AppUser",
                principalColumn: "AppUserID");
        }
    }
}
