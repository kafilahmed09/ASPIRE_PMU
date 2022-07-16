using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class alter_school : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<int>(
                name: "KachaClerkOffice",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaGuardRoom",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaHMR",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaHall",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaResourceCenter",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaSportsRoom",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaStaffRoom",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KachaToilet",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaClerkOffice",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaGuardRoom",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaHMR",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaHall",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaResourceCenter",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaSportsRoom",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaStaffRoom",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakkaToilet",
                schema: "master",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {          

            migrationBuilder.DropColumn(
                name: "KachaClerkOffice",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaGuardRoom",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaHMR",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaHall",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaResourceCenter",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaSportsRoom",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaStaffRoom",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "KachaToilet",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaClerkOffice",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaGuardRoom",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaHMR",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaHall",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaResourceCenter",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaSportsRoom",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaStaffRoom",
                schema: "master",
                table: "School");

            migrationBuilder.DropColumn(
                name: "PakkaToilet",
                schema: "master",
                table: "School");

          
        }
    }
}
