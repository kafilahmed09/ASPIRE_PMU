using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class alter_school_ChildrenReceivingDistanceLearningKits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ChildrenReceivingDistanceLearningKits",
                schema: "master",
                table: "School",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildrenReceivingDistanceLearningKits",
                schema: "master",
                table: "School");
        }
    }
}
