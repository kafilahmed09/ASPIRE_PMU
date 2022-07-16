using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class alter_school_remove_distanceLearning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsdistanceLearningKit",
                schema: "master",
                table: "School");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsdistanceLearningKit",
                schema: "master",
                table: "School",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
