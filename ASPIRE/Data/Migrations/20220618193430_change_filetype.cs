using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class change_filetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndicatorEvidence_FileType_FileTypeId",
                schema: "Schools",
                table: "IndicatorEvidence");

            migrationBuilder.DropIndex(
                name: "IX_IndicatorEvidence_FileTypeId",
                schema: "Schools",
                table: "IndicatorEvidence");

            migrationBuilder.DropColumn(
                name: "FileType",
                schema: "master",
                table: "Indicator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileType",
                schema: "master",
                table: "Indicator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorEvidence_FileTypeId",
                schema: "Schools",
                table: "IndicatorEvidence",
                column: "FileTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndicatorEvidence_FileType_FileTypeId",
                schema: "Schools",
                table: "IndicatorEvidence",
                column: "FileTypeId",
                principalSchema: "master",
                principalTable: "FileType",
                principalColumn: "FileTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
