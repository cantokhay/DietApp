using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.DAL.Migrations
{
    public partial class mg004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AppUser_AppUserID",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserID",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AppUser_AppUserID",
                table: "Products",
                column: "AppUserID",
                principalTable: "AppUser",
                principalColumn: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AppUser_AppUserID",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserID",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AppUser_AppUserID",
                table: "Products",
                column: "AppUserID",
                principalTable: "AppUser",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
