using Microsoft.EntityFrameworkCore.Migrations;

namespace Fizz.Migrations
{
    public partial class addUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "FizzBuzz",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "FizzBuzz");
        }
    }
}
