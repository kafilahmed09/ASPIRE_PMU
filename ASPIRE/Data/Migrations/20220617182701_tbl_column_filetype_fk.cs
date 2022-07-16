using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIRE.Data.Migrations
{
    public partial class tbl_column_filetype_fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FileTypeId",
                schema: "Schools",
                table: "IndicatorEvidence",
                type: "int",
                nullable: false,
                defaultValue: 1);

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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FileTypeId",
                schema: "Schools",
                table: "IndicatorEvidence");
        }
    }
}
