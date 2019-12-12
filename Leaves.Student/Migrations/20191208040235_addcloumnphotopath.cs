using Microsoft.EntityFrameworkCore.Migrations;

namespace Leaves.Student.Migrations
{
    public partial class addcloumnphotopath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPato",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPato",
                table: "Students");
        }
    }
}
